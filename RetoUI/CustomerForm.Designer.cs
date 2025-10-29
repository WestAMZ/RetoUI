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
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            cellphone = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            btn_new = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, name, cellphone, address });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(25, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(845, 411);
            dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "Id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Nombre";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // cellphone
            // 
            cellphone.HeaderText = "Celular";
            cellphone.Name = "cellphone";
            cellphone.ReadOnly = true;
            // 
            // address
            // 
            address.HeaderText = "Dirección";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // btn_new
            // 
            btn_new.Location = new Point(25, 12);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(99, 26);
            btn_new.TabIndex = 1;
            btn_new.Text = "Nuevo";
            btn_new.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 69);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(25);
            panel1.Size = new Size(895, 461);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_new);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 63);
            panel2.TabIndex = 3;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 530);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            Text = "Clientes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn cellphone;
        private DataGridViewTextBoxColumn address;
        private Button btn_new;
        private Panel panel1;
        private Panel panel2;
    }
}