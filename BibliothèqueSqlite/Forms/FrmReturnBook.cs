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
    public partial class FrmReturnBook : FrmMaster
    {
        tblLoan tblLoans;
        public FrmReturnBook(tblLoan _tblLoan)
        {
            InitializeComponent();
            btnDelete.Visible = false;
            btnNew.Visible = false;
            tblLoans = _tblLoan;
            
            using (var model = new MyModel())
                this.Text ="استرجاع الكتاب " + model.tblBooks.Find( tblLoans.idBook).TitalBook;
        }
        public override void GetData()
        {
            tblLoans.dateActualEnty = dateTimePicker1.Value ;
            base.GetData();
        }
        public override void Save()
        {
            using (var model = new MyModel())
            {
                GetData();
                model.tblLoan.AddOrUpdate(tblLoans);
                model.SaveChanges();
            }
            base.Save();
        }
    }
}
