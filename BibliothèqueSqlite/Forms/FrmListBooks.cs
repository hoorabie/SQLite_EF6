using BibliothèqueSqlite.DataConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothèqueSqlite.Forms
{
    public partial class FrmListBooks : Form
    {
        
        public FrmListBooks()
        {
            InitializeComponent();
            this.Load += FrmListBooks_Load;
            this.KeyDown += FrmListBooks_KeyDown;
        }

        private void FrmListBooks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnNew.PerformClick();
            if (e.KeyCode == Keys.F3)
                if (btnDelete.Visible) ;
        }

        private void FrmListBooks_Load(object sender, EventArgs e)
        {
            RefreshData();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor =  Color.FromArgb(48, 48, 65);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.Columns[1].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "تاريخ الاقتناء";
            dataGridView1.Columns[2].HeaderText = "عنوان الكتاب";
            dataGridView1.Columns[3].HeaderText = "المؤلف";
            dataGridView1.Columns[4].HeaderText = "عدد المجلدات";
            dataGridView1.Columns[5].HeaderText = "عدد النسخ";
            dataGridView1.Columns[6].HeaderText = "الكمية المتوفرة";
            dataGridView1.Columns[7].HeaderText = "سعر الاقتناء";
            dataGridView1.Columns[8].HeaderText = "دار النشر";
            dataGridView1.Columns[9].HeaderText = "تصنيف الكتاب";
            dataGridView1.Columns[10].HeaderText = "موقع الكتاب";
            dataGridView1.Columns[11].HeaderText = "حالة الكتاب";

        }
        private void RefreshData()
        {
            using (var model = new MyModel())
            {
                dataGridView1.DataSource = (from book in model.tblBooks
                                            from Publ in model.tblPublishing.Where(p => p.Id == book.idPublishing )
                                            from clsbook in model.tblPublishing.Where(c => c.Id == book.idClassBook)
                                            select new
                                            {
                                                book.Id,
                                                book.dateBook,
                                                book.TitalBook,
                                                book.AuthorName,
                                                book.NmbCopieBook,
                                                book.QteBook,
                                                QuantityAvailable = (book.QteBook)-model.tblLoan.Count(l=>l.idBook==book.Id && l.dateActualEnty==null),
                                                book.PriceBook,
                                                Publ.Publishing,
                                                ClassBook = clsbook.Publishing,
                                                book.SiteBook,
                                                book.BookStatus

                                            }).ToList();
            }
        }

        private void serchBook(string titel)
        {
            if (titel==string.Empty)
            {
                RefreshData();
                return;
            }
            using (var model = new MyModel())
            {
                dataGridView1.DataSource = (from book in model.tblBooks.Where(b => b.TitalBook.Contains(titel)||b.AuthorName.Contains(titel))
                                            from Publ in model.tblPublishing.Where(p => p.Id == book.idPublishing)
                                            from clsbook in model.tblPublishing.Where(c => c.Id == book.idClassBook)
                                            select new
                                            {
                                                book.Id,
                                                book.dateBook,
                                                book.TitalBook,
                                                book.AuthorName,
                                                book.NmbCopieBook,
                                                book.QteBook,
                                                QuantityAvailable = (book.QteBook) - model.tblLoan.Count(l => l.idBook == book.Id && l.dateActualEnty == null),
                                                book.PriceBook,
                                                Publ.Publishing,
                                                ClassBook = clsbook.Publishing,
                                                book.SiteBook, 
                                                book.BookStatus

                                            }).ToList();

            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Frmbooks frmbooks = new Frmbooks();
            frmbooks.ShowDialog();
            RefreshData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = (long)dataGridView1.CurrentRow.Cells[0].Value;
            Frmbooks frmbooks = new Frmbooks(id);
            frmbooks.ShowDialog();
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            long id = (long)dataGridView1.CurrentRow.Cells[0].Value;
            string TitalBook = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            using (var model = new MyModel())
            {

                if (MessageBox.Show(text: "هل تريد حذف الكتاب " + TitalBook, caption: "تأكيد الحذف",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    model.tblBooks.Remove(model.tblBooks.Single(x => x.Id == id));
                    model.SaveChanges();
                    MessageBox.Show("تم حذف الكتاب");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            serchBook(textBox1.Text);
        }

        
    }
}
