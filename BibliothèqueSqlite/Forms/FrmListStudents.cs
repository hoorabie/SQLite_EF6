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
    public partial class FrmListStudents : Form
    {
        public FrmListStudents()
        {
            InitializeComponent();
            this.Load += FrmListStudents_Load;
            this.KeyDown += FrmListStudents_KeyDown;
        }

        private void FrmListStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnNew.PerformClick();
            if (e.KeyCode == Keys.F3)
                if (btnDelete.Visible) ;
        }

        private void FrmListStudents_Load(object sender, EventArgs e)
        {
            RefreshData();
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(48, 48, 65);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "رقم البطاقة";
            dataGridView1.Columns[3].HeaderText = "رقم الهاتف";
        }

        private void RefreshData()
        {
            using (var model = new MyModel())
                dataGridView1.DataSource = model.tblStudents.ToList();
        }

        private void serchBook(string titel)
        {
            if (titel == string.Empty)
            {
                RefreshData();
                return;
            }
            using (var model = new MyModel())
                dataGridView1.DataSource = model.tblStudents.Where(s=> s.nomPrnom.Contains(titel)).ToList();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            long id = (long)dataGridView1.CurrentRow.Cells[0].Value;
            FrmStudents frmStudents = new FrmStudents(id);
            frmStudents.ShowDialog();
            RefreshData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            serchBook(textBox1.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmStudents frmStudents = new FrmStudents();
            frmStudents.ShowDialog();
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            long id = (long)dataGridView1.CurrentRow.Cells[0].Value;
            string nameStudents = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            using (var model = new MyModel())
            {

                if (MessageBox.Show(text: "هل تريد حذف اطالب " + nameStudents, caption: "تأكيد الحذف",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    model.tblStudents.Remove(model.tblStudents.Single(x => x.Id == id));
                    model.SaveChanges();
                    MessageBox.Show("تم حذف الطالب");
                }
            }
        }
    }
}
