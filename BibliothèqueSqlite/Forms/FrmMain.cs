using BibliothèqueSqlite.User_Controls;
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
    public partial class FrmMain : Form
    {
        private Point mouseLocation;
        public static FrmMain _Instance;
        public static FrmMain Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new FrmMain();
                return _Instance;
            }
        }
        public FrmMain()
        {
            InitializeComponent();
            this.Load += FrmMain_Load;
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnHome.PerformClick();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (P_MB.Width == 160)
            {
                P_MB.Width = 40;
                label4.Visible = false;
            }
            else
            {
                P_MB.Width = 160;
                label4.Visible = true;
            }
        }
        private void MarkTop(Button Btn)
        {
            P_Mark.Top = Btn.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            Button myBtn = ((Button)(Control)sender);
            MarkTop(myBtn);


            panelMain.Controls.Clear();
            switch (myBtn.Name)
            {
                case "btnHome":
                    UserMain ucHome = new UserMain();
                    ucHome.Dock = DockStyle.Fill;
                    panelMain.Controls.Add(ucHome);
                    break;

                case "btnBooks":
                    FrmListBooks frm = new FrmListBooks();
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.TopLevel = false;
                    frm.Dock = DockStyle.Fill;
                    panelMain.Controls.Add(frm);
                    frm.Show();
                    break;

                case "btnStudents":
                    FrmListStudents frmListStudents = new FrmListStudents();
                    frmListStudents.FormBorderStyle = FormBorderStyle.None;
                    frmListStudents.TopLevel = false;
                    frmListStudents.Dock = DockStyle.Fill;
                    panelMain.Controls.Add(frmListStudents);
                    frmListStudents.Show();
                    break;

                case "btnBorrow":
                    FrmListLoan frmLoan = new FrmListLoan();
                    frmLoan.FormBorderStyle = FormBorderStyle.None;
                    frmLoan.TopLevel = false;
                    frmLoan.Dock = DockStyle.Fill;
                    panelMain.Controls.Add(frmLoan);
                    frmLoan.Show();
                    break;

                case "btnUser":
                    FrmLogin frmLogin = new FrmLogin(false);
                    frmLogin.FormBorderStyle = FormBorderStyle.None;
                    frmLogin.TopLevel = false;
                    frmLogin.Dock = DockStyle.Fill;
                    panelMain.Controls.Add(frmLogin);
                    frmLogin.Show();
                    break;
                default:
                    

                    break;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState =  FormWindowState.Normal;
        }

        private void panelHeder_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
            panelHeder.Cursor = Cursors.SizeAll;
        }

        private void panelHeder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }


        private void panelHeder_MouseUp(object sender, MouseEventArgs e)
        {
            panelHeder.Cursor = Cursors.Default;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmInfo frmInfo = new FrmInfo();
            frmInfo.ShowDialog();
        }
    }
}
