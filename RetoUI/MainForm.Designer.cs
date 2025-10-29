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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel_top = new Panel();
            pictureBox1 = new PictureBox();
            panel_windows_action = new Panel();
            btn_minimize = new Button();
            btn_maximaze = new Button();
            btn_close = new Button();
            panel_left = new Panel();
            button2 = new Button();
            button1 = new Button();
            btn_inicio = new Button();
            panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_windows_action.SuspendLayout();
            panel_left.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.White;
            panel_top.Controls.Add(pictureBox1);
            panel_top.Controls.Add(panel_windows_action);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(0, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(999, 44);
            panel_top.TabIndex = 0;
            panel_top.MouseDown += top_panel_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
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
            panel_left.Controls.Add(button2);
            panel_left.Controls.Add(button1);
            panel_left.Controls.Add(btn_inicio);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 44);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(200, 606);
            panel_left.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(13, 27, 42);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.customers;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 106);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(200, 53);
            button2.TabIndex = 4;
            button2.Text = "Ventas";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(13, 27, 42);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.sales;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 53);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(200, 53);
            button1.TabIndex = 3;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            // 
            // btn_inicio
            // 
            btn_inicio.BackColor = Color.FromArgb(13, 27, 42);
            btn_inicio.Cursor = Cursors.Hand;
            btn_inicio.Dock = DockStyle.Top;
            btn_inicio.FlatAppearance.BorderSize = 0;
            btn_inicio.FlatStyle = FlatStyle.Flat;
            btn_inicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_inicio.ForeColor = Color.White;
            btn_inicio.Image = Properties.Resources.home;
            btn_inicio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inicio.Location = new Point(0, 0);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Padding = new Padding(10, 0, 0, 0);
            btn_inicio.Size = new Size(200, 53);
            btn_inicio.TabIndex = 2;
            btn_inicio.Text = "Inicio";
            btn_inicio.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 650);
            Controls.Add(panel_left);
            Controls.Add(panel_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            FormClosed += MainForm_FormClosed;
            panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_windows_action.ResumeLayout(false);
            panel_left.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Panel panel_left;
        private Panel panel_windows_action;
        private Button btn_maximaze;
        private Button btn_close;
        private Button btn_minimize;
        private PictureBox pictureBox1;
        private Button btn_inicio;
        private Button button2;
        private Button button1;
    }
}