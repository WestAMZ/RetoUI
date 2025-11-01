namespace RetoUI
{
    partial class HomeForm
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
            panel_top = new Panel();
            lbl_title = new Label();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(27, 38, 59);
            panel_top.Controls.Add(lbl_title);
            panel_top.Location = new Point(12, 12);
            panel_top.MinimumSize = new Size(845, 96);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(904, 140);
            panel_top.TabIndex = 4;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.White;
            lbl_title.Location = new Point(25, 10);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(88, 37);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "Inicio";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 90, 119);
            ClientSize = new Size(930, 450);
            Controls.Add(panel_top);
            Name = "HomeForm";
            Text = "InicioForm";
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_top;
        private Label lbl_title;
    }
}