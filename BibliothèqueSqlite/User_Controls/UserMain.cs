using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliothèqueSqlite.DataConnection;

namespace BibliothèqueSqlite.User_Controls
{
    public partial class UserMain : UserControl
    {
        public UserMain()
        {
            InitializeComponent();
            this.Load += UserMain_Load;
        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            using (var model = new MyModel())
            {
                SumBookAll.Text = model.tblBooks.Sum(x => x.QteBook).ToString();
                SumBookLoan.Text = model.tblLoan.Count(w => w.dateActualEnty == null).ToString();
                SumBookLoanRotar.Text = model.tblLoan.Count(w => w.dateActualEnty == null && w.dateEntry < DateTime.Now).ToString();
                SumStudents.Text = model.tblStudents.Count().ToString();
            }
                
        }
    }
}
