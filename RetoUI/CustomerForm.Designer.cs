namespace RetoUI
{
    partial class CustomerForm
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
            gridview = new DataGridView();
            btn_new = new Button();
            panel1 = new Panel();
            panel_top = new Panel();
            lbl_customer = new Label();
            btn_edit = new Button();
            panel2 = new Panel();
            btn_delete = new Button();
            ((System.ComponentModel.ISupportInitialize)gridview).BeginInit();
            panel1.SuspendLayout();
            panel_top.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // gridview
            // 
            gridview.AllowUserToAddRows = false;
            gridview.AllowUserToDeleteRows = false;
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridview.Dock = DockStyle.Fill;
            gridview.Location = new Point(25, 25);
            gridview.Name = "gridview";
            gridview.ReadOnly = true;
            gridview.Size = new Size(894, 651);
            gridview.TabIndex = 0;
            // 
            // btn_new
            // 
            btn_new.Dock = DockStyle.Right;
            btn_new.Location = new Point(124, 10);
            btn_new.Margin = new Padding(50);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(99, 42);
            btn_new.TabIndex = 1;
            btn_new.Text = "Nuevo";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 225, 221);
            panel1.Controls.Add(panel_top);
            panel1.Controls.Add(gridview);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25);
            panel1.Size = new Size(944, 701);
            panel1.TabIndex = 2;
            // 
            // panel_top
            // 
            panel_top.BackColor = Color.FromArgb(27, 38, 59);
            panel_top.Controls.Add(panel2);
            panel_top.Controls.Add(lbl_customer);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(25, 25);
            panel_top.MinimumSize = new Size(845, 96);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(894, 121);
            panel_top.TabIndex = 3;
            // 
            // lbl_customer
            // 
            lbl_customer.AutoSize = true;
            lbl_customer.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_customer.ForeColor = Color.White;
            lbl_customer.Location = new Point(25, 10);
            lbl_customer.Name = "lbl_customer";
            lbl_customer.Size = new Size(119, 37);
            lbl_customer.TabIndex = 2;
            lbl_customer.Text = "Clientes";
            // 
            // btn_edit
            // 
            btn_edit.Dock = DockStyle.Right;
            btn_edit.Location = new Point(223, 10);
            btn_edit.Margin = new Padding(50);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(99, 42);
            btn_edit.TabIndex = 4;
            btn_edit.Text = "Editar";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_delete);
            panel2.Controls.Add(btn_new);
            panel2.Controls.Add(btn_edit);
            panel2.Location = new Point(269, 45);
            panel2.Margin = new Padding(50);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(332, 62);
            panel2.TabIndex = 5;
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Right;
            btn_delete.Location = new Point(25, 10);
            btn_delete.Margin = new Padding(50);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(99, 42);
            btn_delete.TabIndex = 5;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 701);
            Controls.Add(panel1);
            Name = "CustomerForm";
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)gridview).EndInit();
            panel1.ResumeLayout(false);
            panel_top.ResumeLayout(false);
            panel_top.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridview;
        private Button btn_new;
        private Panel panel1;
        private Panel panel_top;
        private Label lbl_customer;
        private Button btn_edit;
        private Panel panel2;
        private Button btn_delete;
    }
}