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
    public partial class FrmLogin : Form
    {
        private bool ALT_F4 = false;
        private bool isLogin;
        public FrmLogin(bool _isLogin)
        {
            isLogin = _isLogin;
            InitializeComponent();
            this.Load += FrmLogin_Load;
            this.KeyDown += FrmLogin_KeyDown;
            this.FormClosing += FrmLogin_FormClosing;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if(isLogin==false)
            {
                btnOK.Text = "التالي";
                lblText.Text = "ادخل اسم المستخدم و كلمة المورور القديمان";
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ALT_F4)
            {
                e.Cancel = true;
                return;
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
            if (e.KeyCode.Equals(Keys.R) && e.Alt)
            {

            }
            ALT_F4 = (e.KeyCode.Equals(Keys.F4) && e.Alt == true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isLogin)
                Application.Exit();
            else
                this.Close();
        }
        private bool VerifyData()
        {
            if (txtUser.Text == Properties.Settings.Default.usr &&
               txtPsw.Text == Properties.Settings.Default.psw)
                return true;
            else
                return false;
        }
        private bool IsDataValdiate()
        {
            MasterClass.EpClear();
            int NumberOfErrors = 0;
            NumberOfErrors += txtUser.IsTextValide() ? 0 : 1;
            NumberOfErrors += txtPsw.IsTextValide() ? 0 : 1;

            return (NumberOfErrors == 0);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if(IsDataValdiate())
            {
                if (isLogin)
                {
                    if (VerifyData())
                    {
                        this.Close();
                        FrmMain.Instance.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة");
                    }
                }
                else if (isLogin == false && btnOK.Text == "التالي")
                {
                    if (VerifyData())
                    {
                        btnOK.Text = "حفظ";
                        lblText.Text = "ادخل اسم المستخدم و كلمة المورور الجديدة";
                        txtUser.Clear();
                        txtPsw.Clear();
                        txtUser.Focus();
                    }
                    else
                        MessageBox.Show("اسم المستخدم او كلمة المرور خاطئة");

                }
                else if (isLogin == false && btnOK.Text == "حفظ")
                {
                    Properties.Settings.Default.usr = txtUser.Text;
                    Properties.Settings.Default.psw = txtPsw.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("تم حفظ البيانات الجديدة");
                    this.Close();
                }


            }

        }
    }
}
