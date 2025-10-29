using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoUI
{
    public partial class MainForm : Form
    {
        // Importamos funciones nativas de user32.dll
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private Form activeForm = null;
        private bool menuExpand = true;

        // Constantes para mover la ventana
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void top_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_maximaze_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            if (this.activeForm != null)
            {
                // Hacemos esto para que nuevamente el form que mostramos en el panel se redimencione
                this.activeForm.WindowState = FormWindowState.Normal;
                this.activeForm.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CloseActiveForm();
            SetActiveForm(new CustomerForm());
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {

        }
        private void CloseActiveForm()
        {
            if (activeForm != null)
            {
                this.panel_main.Controls.Clear();
                this.activeForm.Close();
            }
            this.activeForm = null;
        }
        private void SetActiveForm(Form form)
        {
            this.activeForm = form;
            this.activeForm.TopLevel = false;
            this.panel_main.Controls.Add(this.activeForm);
            this.activeForm.BringToFront();
            this.activeForm.Show();
        }

        private void timer_menu_transition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                this.panel_left.Width += 10;
                if (this.panel_left.Width >= 200)
                {
                    timer_sidebar_transition.Stop();
                    menuExpand = true;
                    foreach (Control control in this.panel_left.Controls)
                    {
                        control.Visible = true;
                    }
                }
            }
            else
            {
                this.panel_left.Width -= 10;
                if (this.panel_left.Width <= 10)
                {
                    this.panel_left.Width = 0;
                    timer_sidebar_transition.Stop();
                    menuExpand = false;
                    foreach (Control control in this.panel_left.Controls)
                    {
                        control.Visible = false;
                    }
                }
            }
        }

        private void picture_toggle_Click(object sender, EventArgs e)
        {
            timer_sidebar_transition.Start();
        }
    }
}
