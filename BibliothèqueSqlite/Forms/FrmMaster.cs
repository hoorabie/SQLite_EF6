using BibliothèqueSqlite.Class;
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
    public partial class FrmMaster : Form
    {
        public FrmMaster()
        {
            InitializeComponent();
            this.KeyDown += FrmMaster_KeyDown;
            btnSave.Click += BtnSave_Click;
            btnNew.Click += BtnNew_Click;
            btnDelete.Click += BtnDelete_Click;
           
        }

        

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsDataValdiate())
                Save();
           
        }

      
        public virtual void Save()
        {
            MessageBox.Show("تم الحفظ بنجاح");
            RefreshData();

        }
        public virtual void New()
        {
            MasterClass.EpClear();
            GetData();
        }
        public virtual void Delete()
        {

        }
        public virtual void GetData()
        {

        }
        public virtual void SetData()
        {

        }
        public virtual void RefreshData()
        {

        }
        public virtual bool IsDataValdiate()
        {
            return true;
        }
       
        private void FrmMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (btnSave.Visible)
                    btnSave.PerformClick();
            }
            if (e.KeyCode == Keys.F2)
            {
                if (btnNew.Visible)
                    btnNew.PerformClick();
            }
            if (e.KeyCode == Keys.F3)
            {
                if (btnDelete.Visible)
                    btnDelete.PerformClick();
            }
           
        }
    }
}
