namespace RetoUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel_top = new Panel();
            picture_toggle = new PictureBox();
            panel_windows_action = new Panel();
            btn_minimize = new Button();
            btn_maximaze = new Button();
            btn_close = new Button();
            panel_left = new Panel();
            btn_sales = new Button();
            btn_customer = new Button();
            btn_home = new Button();
            panel_main = new Panel();
            timer_sidebar_transition = new System.Windows.Forms.Timer(components);
            panel_user = new Panel();
            lbl_user_name = new Label();
            pictureBox1 = new PictureBox();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_toggle).BeginInit();
            panel_windows_action.SuspendLayout();
            panel_left.SuspendLayout();
            panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.White;
            panel_top.Controls.Add(picture_toggle);
            panel_top.Controls.Add(panel_windows_action);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(999, 44);
            panel_top.TabIndex = 0;
            panel_top.MouseDown += top_panel_MouseDown;
            // 
            // picture_toggle
            // 
            picture_toggle.Cursor = Cursors.Hand;
            picture_toggle.Image = (Image)resources.GetObject("picture_toggle.Image");
            picture_toggle.Location = new Point(12, 4);
            picture_toggle.Name = "picture_toggle";
            picture_toggle.Size = new Size(35, 34);
            picture_toggle.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_toggle.TabIndex = 3;
            picture_toggle.TabStop = false;
            picture_toggle.Click += picture_toggle_Click;
            // 
            // panel_windows_action
            // 
            panel_windows_action.Controls.Add(btn_minimize);
            panel_windows_action.Controls.Add(btn_maximaze);
            panel_windows_action.Controls.Add(btn_close);
            panel_windows_action.Dock = DockStyle.Right;
            panel_windows_action.Location = new Point(914, 0);
            panel_windows_action.Name = "panel_windows_action";
            panel_windows_action.Size = new Size(85, 44);
            panel_windows_action.TabIndex = 2;
            // 
            // btn_minimize
            // 
            btn_minimize.ForeColor = SystemColors.HotTrack;
            btn_minimize.Location = new Point(3, 7);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(25, 25);
            btn_minimize.TabIndex = 2;
            btn_minimize.Text = "-";
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_maximaze
            // 
            btn_maximaze.ForeColor = SystemColors.HotTrack;
            btn_maximaze.Location = new Point(29, 7);
            btn_maximaze.Name = "btn_maximaze";
            btn_maximaze.Size = new Size(25, 25);
            btn_maximaze.TabIndex = 1;
            btn_maximaze.Text = "▢";
            btn_maximaze.UseVisualStyleBackColor = true;
            btn_maximaze.Click += btn_maximaze_Click;
            // 
            // btn_close
            // 
            btn_close.ForeColor = Color.Red;
            btn_close.Location = new Point(54, 7);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(25, 25);
            btn_close.TabIndex = 0;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // panel_left
            // 
            panel_left.BackColor = Color.FromArgb(13, 27, 42);
            panel_left.Controls.Add(btn_sales);
            panel_left.Controls.Add(btn_customer);
            panel_left.Controls.Add(btn_home);
            panel_left.Controls.Add(panel_user);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 44);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(200, 493);
            panel_left.TabIndex = 1;
            // 
            // btn_sales
            // 
            btn_sales.BackColor = Color.FromArgb(13, 27, 42);
            btn_sales.Cursor = Cursors.Hand;
            btn_sales.Dock = DockStyle.Top;
            btn_sales.FlatAppearance.BorderSize = 0;
            btn_sales.FlatStyle = FlatStyle.Flat;
            btn_sales.Font = new Font("Segoe UI", 14.25F);
            btn_sales.ForeColor = Color.White;
            btn_sales.Image = Properties.Resources.customers;
            btn_sales.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sales.Location = new Point(0, 281);
            btn_sales.Name = "btn_sales";
            btn_sales.Padding = new Padding(8, 0, 0, 0);
            btn_sales.Size = new Size(200, 53);
            btn_sales.TabIndex = 4;
            btn_sales.Text = "     Ventas";
            btn_sales.UseVisualStyleBackColor = false;
            btn_sales.Click += btn_sales_Click;
            // 
            // btn_customer
            // 
            btn_customer.BackColor = Color.FromArgb(13, 27, 42);
            btn_customer.Cursor = Cursors.Hand;
            btn_customer.Dock = DockStyle.Top;
            btn_customer.FlatAppearance.BorderSize = 0;
            btn_customer.FlatStyle = FlatStyle.Flat;
            btn_customer.Font = new Font("Segoe UI", 14.25F);
            btn_customer.ForeColor = Color.White;
            btn_customer.Image = Properties.Resources.sales;
            btn_customer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_customer.Location = new Point(0, 228);
            btn_customer.Name = "btn_customer";
            btn_customer.Padding = new Padding(8, 0, 0, 0);
            btn_customer.Size = new Size(200, 53);
            btn_customer.TabIndex = 3;
            btn_customer.Text = "     Clientes";
            btn_customer.UseVisualStyleBackColor = false;
            btn_customer.Click += btn_customer_Click;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.FromArgb(13, 27, 42);
            btn_home.Cursor = Cursors.Hand;
            btn_home.Dock = DockStyle.Top;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_home.ForeColor = Color.White;
            btn_home.Image = Properties.Resources.home;
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(0, 175);
            btn_home.Name = "btn_home";
            btn_home.Padding = new Padding(8, 0, 0, 0);
            btn_home.Size = new Size(200, 53);
            btn_home.TabIndex = 2;
            btn_home.Text = "     Inicio";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.FromArgb(27, 38, 59);
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(200, 44);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(799, 493);
            panel_main.TabIndex = 2;
            // 
            // timer_sidebar_transition
            // 
            timer_sidebar_transition.Interval = 10;
            timer_sidebar_transition.Tick += timer_menu_transition_Tick;
            // 
            // panel_user
            // 
            panel_user.Controls.Add(pictureBox1);
            panel_user.Controls.Add(lbl_user_name);
            panel_user.Dock = DockStyle.Top;
            panel_user.Location = new Point(0, 0);
            panel_user.Name = "panel_user";
            panel_user.Size = new Size(200, 175);
            panel_user.TabIndex = 5;
            // 
            // lbl_user_name
            // 
            lbl_user_name.AutoSize = true;
            lbl_user_name.Font = new Font("Segoe UI", 12F);
            lbl_user_name.ForeColor = Color.White;
            lbl_user_name.Location = new Point(34, 145);
            lbl_user_name.Name = "lbl_user_name";
            lbl_user_name.Size = new Size(123, 21);
            lbl_user_name.TabIndex = 0;
            lbl_user_name.Text = "Name Lastname";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(34, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 120);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(999, 537);
            Controls.Add(panel_main);
            Controls.Add(panel_left);
            Controls.Add(panel_top);
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture_toggle).EndInit();
            panel_windows_action.ResumeLayout(false);
            panel_left.ResumeLayout(false);
            panel_user.ResumeLayout(false);
            panel_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Panel panel_left;
        private Panel panel_windows_action;
        private Button btn_maximaze;
        private Button btn_close;
        private Button btn_minimize;
        private PictureBox picture_toggle;
        private Button btn_home;
        private Button btn_sales;
        private Button btn_customer;
        private Panel panel_main;
        private System.Windows.Forms.Timer timer_sidebar_transition;
        private Panel panel_user;
        private Label lbl_user_name;
        private PictureBox pictureBox1;
    }
}