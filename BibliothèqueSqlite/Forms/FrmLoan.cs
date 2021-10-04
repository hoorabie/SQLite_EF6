using BibliothèqueSqlite.Class;
using BibliothèqueSqlite.DataConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothèqueSqlite.Forms
{
    public partial class FrmLoan : FrmMaster
    {
        tblLoan tblLoan;
        tblBooks tblBooks;
        tblStudents tblStudents;
        public FrmLoan()
        {
            InitializeComponent();
            this.Load += FrmLoan_Load;
            New();
        }

       

        public FrmLoan(long id)
        {
            InitializeComponent();

            using (var model = new MyModel())
            {
                tblLoan = model.tblLoan.Single(m => m.Id == id);
                tblBooks = model.tblBooks.Single(b => b.Id == tblLoan.idBook);
                tblStudents = model.tblStudents.Single(b => b.Id == tblLoan.idStudents);
                this.Text = "تعديل على اعارة الكتاب " + tblBooks.TitalBook;
            }
            RefreshData();
            GetData();
        }
        private void FrmLoan_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public override void RefreshData()
        {
            using (var model = new MyModel())
            {
                cmbTitalBook.DataSource = model.tblBooks.ToList();
                cmbTitalBook.DisplayMember = nameof(tblBooks.TitalBook);
                cmbTitalBook.ValueMember = nameof(tblBooks.Id);

                cmbnomPrnom.DataSource = model.tblStudents.ToList();
                cmbnomPrnom.DisplayMember = nameof(tblStudents.nomPrnom);
                cmbnomPrnom.ValueMember = nameof(tblStudents.Id);
            }

            base.RefreshData();
        }
        public override void New()
        {
            this.Text = "اعارة كتاب ";
            tblLoan = new tblLoan()
            {
                dateExit = DateTime.Now,
                dateEntry = DateTime.Now
            };
            tblBooks = new tblBooks();
            tblStudents = new tblStudents();
            cmbTitalBook.Focus();
            base.New();
        }


        public override void GetData()
        {
            cmbTitalBook.SelectedValue = tblBooks.Id;
            cmbnomPrnom.SelectedValue = tblStudents.Id;
            cmbStatus.Text = tblLoan.BookStatus;
            dtpExit.Value = (DateTime)tblLoan.dateExit;
            dtpEntry.Value = (DateTime)tblLoan.dateEntry;
            base.GetData();
        }
        public override void SetData()
        {
            tblLoan.idBook = (long?)cmbTitalBook.SelectedValue;
            tblLoan.idStudents = (long?)cmbnomPrnom.SelectedValue;
            tblLoan.dateExit = dtpExit.Value;
            tblLoan.dateEntry = dtpEntry.Value;
            tblLoan.BookStatus = cmbStatus.Text;

            base.SetData();
        }
        public override bool IsDataValdiate()
        {

            MasterClass.EpClear();
            int NumberOfErrors = 0;
            NumberOfErrors += cmbTitalBook.IsSelectValue() ? 0 : 1;
            NumberOfErrors += cmbnomPrnom.IsSelectValue() ? 0 : 1;
            return (NumberOfErrors == 0);
        }
        public override void Save()
        {
            using (var model = new MyModel())
            {
                SetData();
                model.tblLoan.AddOrUpdate(tblLoan);
                model.SaveChanges();
            }
            base.Save();
        }
        public override void Delete()
        {
            if (tblLoan.Id == 0)
                return;
            using (var model = new MyModel())
            {

                if (MessageBox.Show(text: "هل تريد حذف اعارة الكتاب " + tblBooks.TitalBook, caption: "تأكيد الحذف",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SetData();
                    model.tblLoan.Remove(model.tblLoan.Single(x => x.Id == tblLoan.Id));
                    model.SaveChanges();
                    MessageBox.Show("تم حذف الاعارة ");
                }
            }
            New();
            base.Delete();
        }

        private void btnNewPublishing_Click(object sender, EventArgs e)
        {
            Frmbooks frmbooks = new Frmbooks();
            frmbooks.ShowDialog();
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmStudents frmStudents = new FrmStudents();
            frmStudents.ShowDialog();
            RefreshData();
        }
    }
}
