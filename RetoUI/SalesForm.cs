using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetoUI.Extensions;

namespace RetoUI
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            LoadSales();
            this.setGridStiles(this.gridview);
        }
        private void LoadSales()
        {
            var customer = DataReader.Read().data.sales.Select(x => (new { id = x.id, NomProducto = x.product, Precio = x.price, Cantidad = x.amount, Fecha = x.date })).ToList();
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

                Sale sale_to_delete = root.data.sales.Where(x => x.id == id_to_delete).FirstOrDefault();
                if (sale_to_delete != null)
                {
                    root.data.sales.Remove(sale_to_delete);
                    DataReader.Write(root);
                }
                LoadSales();
            }
        }
    }
}
