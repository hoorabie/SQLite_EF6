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
    public partial class FrmStudents : FrmMaster
    {
        tblStudents tblStudents;
        public FrmStudents()
        {
            InitializeComponent();
           
            New();
        }
        public FrmStudents(long id)
        {
            InitializeComponent();
           
            using (var model = new MyModel())
            {
                tblStudents = model.tblStudents.Single(m => m.Id == id);
            }
            this.Text = "تعديل بيانات الطالب " + tblStudents.nomPrnom;
            GetData();
        }
       
        public override void New()
        {
            this.Text = "اضافة بيانات طالب جديد";
            tblStudents = new tblStudents();
            txtnomPrnom.Focus();
            base.New();
        }
        public override void GetData()
        {
            txtnomPrnom.Text = tblStudents.nomPrnom;
            txtcardNumber.Text = tblStudents.cardNumber;
            txtphoneNumber.Text = tblStudents.phoneNumber;
           
            base.GetData();
        }
        public override void SetData()
        {
            tblStudents.nomPrnom = txtnomPrnom.Text;
            tblStudents.cardNumber = txtcardNumber.Text;
            tblStudents.phoneNumber = txtphoneNumber.Text;
            base.SetData();
        }
        public override bool IsDataValdiate()
        {
            MasterClass.EpClear();
            int NumberOfErrors = 0;
            NumberOfErrors += txtnomPrnom.IsTextValide() ? 0 : 1;
            return (NumberOfErrors == 0);
        }
        public override void Save()
        {
            using (var model = new MyModel())
            {
                SetData();
                model.tblStudents.AddOrUpdate(tblStudents);
                model.SaveChanges();
            }
            base.Save();
        }
        public override void Delete()
        {
            if (tblStudents.Id == 0)
                return;
            using (var model = new MyModel())
            {

                if (MessageBox.Show(text: "هل تريد حذف بيانات الطالب " + tblStudents.nomPrnom, caption: "تأكيد الحذف",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SetData();
                    model.tblStudents.Remove(model.tblStudents.Single(x => x.Id == tblStudents.Id));
                    model.SaveChanges();
                    MessageBox.Show("تم حذف بيانات الطالب");
                }
            }
            New();
            base.Delete();
        }
    }
}
