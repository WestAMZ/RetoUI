namespace RetoUI
{
    partial class SalesForm
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
            panel2 = new Panel();
            btn_delete = new Button();
            btn_new = new Button();
            btn_edit = new Button();
            lbl_title = new Label();
            gridview = new DataGridView();
            panel_top.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridview).BeginInit();
            SuspendLayout();
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(27, 38, 59);
            panel_top.Controls.Add(panel2);
            panel_top.Controls.Add(lbl_title);
            panel_top.Location = new Point(12, 12);
            panel_top.MinimumSize = new Size(845, 96);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(904, 140);
            panel_top.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_new);
            panel2.Controls.Add(btn_edit);
            panel2.Location = new Point(0, 50);
            panel2.Margin = new Padding(50);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(904, 62);
            panel2.TabIndex = 5;
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Left;
            btn_delete.Location = new Point(208, 10);
            btn_delete.Margin = new Padding(50);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(99, 42);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            btn_new.Dock = DockStyle.Left;
            btn_new.Location = new Point(109, 10);
            btn_new.Margin = new Padding(50);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(99, 42);
            btn_new.TabIndex = 1;
            btn_new.Text = "Nuevo";
            btn_new.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Dock = DockStyle.Left;
            btn_edit.Location = new Point(10, 10);
            btn_edit.Margin = new Padding(50);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(99, 42);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "Editar";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.White;
            lbl_title.Location = new Point(25, 10);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(102, 37);
            lbl_title.TabIndex = 2;
            lbl_title.Text = "Ventas";
            // 
            // gridview
            // 
            gridview.AllowUserToAddRows = false;
            gridview.AllowUserToDeleteRows = false;
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridview.Location = new Point(12, 162);
            gridview.Name = "gridview";
            gridview.ReadOnly = true;
            gridview.Size = new Size(904, 459);
            gridview.TabIndex = 0;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(65, 90, 119);
            ClientSize = new Size(928, 633);
            Controls.Add(panel_top);
            Controls.Add(gridview);
            MaximumSize = new Size(944, 672);
            Name = "SalesForm";
            Text = "SalesForm";
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridview).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_top;
        private Panel panel2;
        private Button btn_delete;
        private Button btn_new;
        private Button btn_edit;
        private Label lbl_title;
        private DataGridView gridview;
    }
}