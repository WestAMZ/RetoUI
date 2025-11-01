namespace RetoUI
{
    partial class LoadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar = new ProgressBar();
            lbl_welcome = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // progressBar
            // 
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Location = new Point(0, 101);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(418, 23);
            progressBar.TabIndex = 0;
            // 
            // lbl_welcome
            // 
            lbl_welcome.AutoSize = true;
            lbl_welcome.Font = new Font("Segoe UI", 20F);
            lbl_welcome.ForeColor = Color.White;
            lbl_welcome.Location = new Point(125, 26);
            lbl_welcome.Name = "lbl_welcome";
            lbl_welcome.Size = new Size(149, 37);
            lbl_welcome.TabIndex = 1;
            lbl_welcome.Text = "Bienvenido";
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 27, 42);
            ClientSize = new Size(418, 124);
            Controls.Add(lbl_welcome);
            Controls.Add(progressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar;
        private Label lbl_welcome;
        private System.Windows.Forms.Timer timer;
    }
}
