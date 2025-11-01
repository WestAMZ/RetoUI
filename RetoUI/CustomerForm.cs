using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using RetoUI.Extensions;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;

namespace RetoUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            LoadCustomers();
            this.setGridStiles(this.gridview);
        }

        private void LoadCustomers()
        {
            var customer = DataReader.Read().data.customers.Select(x => (new { id = x.id, Nombre = x.name, Celular = x.cellphone })).ToList();
            gridview.DataSource = customer;
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (this.gridview.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow row = this.gridview.SelectedRows[0];

                // Get a field value by column name
                int id_to_delete;
                int.TryParse(row.Cells["Id"].Value.ToString(), out id_to_delete);


                Root root = DataReader.Read();

                Customer customer_to_delete = root.data.customers.Where(x => x.id == id_to_delete).FirstOrDefault();
                if (customer_to_delete != null) 
                {
                    root.data.customers.Remove(customer_to_delete);
                    DataReader.Write(root);
                }
                LoadCustomers();
            }

        }
    }
}
