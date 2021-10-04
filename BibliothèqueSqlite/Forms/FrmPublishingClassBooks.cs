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
    public partial class FrmPublishingClassBooks : FrmMaster
    {
        bool ispuplishing;
        tblPublishing tblPublishing;
        public FrmPublishingClassBooks(bool isPuplishing)
        {
            this.ispuplishing = isPuplishing;
            InitializeComponent();
            this.Load += FrmPublishingClassBooks_Load;
            New();
        }
        public FrmPublishingClassBooks(bool isPuplishing,long id)
        {
            this.ispuplishing = isPuplishing;
            InitializeComponent();
            using (var model = new MyModel())
            {
                tblPublishing = model.tblPublishing.Single(p => p.Id == id);
            }
            this.Text = ispuplishing == true ? "اضافة دار نشر جديد" + tblPublishing.Publishing : "اضافة تصنيف جديد" + tblPublishing.Publishing;
            GetData();
        }
        private void FrmPublishingClassBooks_Load(object sender, EventArgs e)
        {
            
        }
        public override void New()
        {
            this.Text = ispuplishing==true ? "اضافة دار نشر جديد": "اضافة تصنيف جديد";
            tblPublishing = new tblPublishing(){ isPublishing = ispuplishing};
            txt.Focus();
            base.New();
        }
        public override void GetData()
        {
            txt.Text = tblPublishing.Publishing;
            base.GetData();
        }
        public override void SetData()
        {
            tblPublishing.Publishing = txt.Text ;
            base.SetData();
        }
        public override bool IsDataValdiate()
        {
            MasterClass.EpClear();
            int NumberOfErrors = 0;
            NumberOfErrors += txt.IsTextValide() ? 0 : 1;
            return (NumberOfErrors == 0);
        }
        public override void Save()
        {
            using (var model = new MyModel())
            {
                SetData();
                model.tblPublishing.AddOrUpdate(tblPublishing);
                model.SaveChanges();
            }
            base.Save();
        }

        public override void Delete()
        {
            if (tblPublishing.Id == 0)
                return;
            using (var model = new MyModel())
            {
                string txtmsg = ispuplishing == true ? "هل تريد حذف دار نشر " : "هل تريد حذف التصنيف ";

                if (MessageBox.Show(text: txtmsg + tblPublishing.Publishing, caption: "تأكيد الحذف",
                    buttons: MessageBoxButtons.YesNo,
                    icon: MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SetData();
                    model.tblPublishing.Remove(model.tblPublishing.Single(x => x.Id == tblPublishing.Id));
                    model.SaveChanges();
                    MessageBox.Show("تم الحذف ");
                }
            }
            New();
            base.Delete();
        }
    }
}
