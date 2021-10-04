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
    public partial class FrmListLoan : Form
    {
        public FrmListLoan()
        {
            InitializeComponent();
            this.Load += FrmListLoan_Load;
            this.KeyDown += FrmListLoan_KeyDown;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
        }

        private void FrmListLoan_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F2)
                    btnNew.PerformClick();
            if (e.KeyCode == Keys.F3)
                if (btnDelete.Visible)
            if (e.KeyCode == Keys.F4)
                    button1.PerformClick();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = (long)dataGridView1.CurrentRow.Cells[0].Value;
            FrmLoan frmLoans = new FrmLoan(id);
            frmLoans.ShowDialog();
            RefreshData();
        }

        private void FrmListLoan_Load(object sender, EventArgs e)
        {

            RefreshData();

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 48, 65);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";

            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[2].HeaderText = "عنوان الكتاب";
            dataGridView1.Columns[3].HeaderText = "اسم الطالب";
            dataGridView1.Columns[4].HeaderText = "تاريخ الخروج";
            dataGridView1.Columns[5].HeaderText = "تاريخ الارجاع";
            dataGridView1.Columns[6].HeaderText = "تاريخ الدخول";

        }

        private void RefreshData()
        {
            using (var model = new MyModel())
            {
                dataGridView1.DataSource = (from Loan in model.tblLoan
                                            from book in model.tblBooks.Where(b => b.Id == Loan.idBook)
                                            from Stud in model.tblStudents.Where(p => p.Id == Loan.idStudents)
                                            select new
                                            {
                                                Loan.Id,
                                                Loan.idBook,
                                                book.TitalBook,
                                                Stud.nomPrnom,
                                                Loan.dateExit,
                                                Loan.dateEntry,
                                                Loan.dateActualEnty
                                            }).ToList();
            }
        }

    
        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmLoan frmLoan = new FrmLoan();
            frmLoan.ShowDialog();
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            long id = (long)dataGridView1.CurrentRow.Cells[0].Value;
            string TitalBook = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            using (var model = new MyModel())
            {

                if (MessageBox.Show(text: "هل تريد حذف اعارة الكتاب " + TitalBook, caption: "تأكيد الحذف",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    model.tblLoan.Remove(model.tblLoan.Single(x => x.Id == id));
                    model.SaveChanges();
                    MessageBox.Show("تم حذف الاعارة");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long id = (long)dataGridView1.CurrentRow.Cells[0].Value;
            tblLoan tblLoan;
            using (var model = new MyModel())
            {
                tblLoan = model.tblLoan.Single(m => m.Id == id);
                FrmReturnBook frmReturnBook = new FrmReturnBook(tblLoan);
                frmReturnBook.ShowDialog();
                RefreshData();
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            using (var model = new MyModel())
            {
                var data = (from Loan in model.tblLoan
                                            from book in model.tblBooks.Where(b => b.Id == Loan.idBook)
                                            from Stud in model.tblStudents.Where(p => p.Id == Loan.idStudents)
                                            select new
                                            {
                                                Loan.Id,
                                                Loan.idBook,
                                                book.TitalBook,
                                                Stud.nomPrnom,
                                                Loan.dateExit,
                                                Loan.dateEntry,
                                                Loan.dateActualEnty
                                            }).ToList();
                dataGridView1.DataSource = data.Where(x => x.dateActualEnty == null && DateTime.Now > x.dateEntry ).ToList();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            using (var model = new MyModel())
            {
                var data = (from Loan in model.tblLoan
                            from book in model.tblBooks.Where(b => b.Id == Loan.idBook)
                            from Stud in model.tblStudents.Where(p => p.Id == Loan.idStudents)
                            select new
                            {
                                Loan.Id,
                                Loan.idBook,
                                book.TitalBook,
                                Stud.nomPrnom,
                                Loan.dateExit,
                                Loan.dateEntry,
                                Loan.dateActualEnty
                            }).ToList();
                dataGridView1.DataSource = data.Where(x =>  DateTime.Now > x.dateEntry).ToList();
            }
        }
    }
}
