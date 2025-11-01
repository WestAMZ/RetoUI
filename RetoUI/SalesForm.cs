using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetoUI
{
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            LoadSales();
            setGridStiles(this.gridview);
        }
        private void LoadSales()
        {
            var customer = DataReader.Read().data.sales.Select(x => (new { id = x.id, NomProducto = x.product, Precio = x.price, Cantidad = x.amount, Fecha = x.date })).ToList();
            gridview.DataSource = customer;
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void setGridStiles(DataGridView dgv)
        {
            // Color de fondo general
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;

            // Alternar color de filas (efecto “striped”)
            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240); // gris suave

            // Color de texto
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 153, 255); // azul selección
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            // Estilo del encabezado
            dgv.EnableHeadersVisualStyles = false; // Permite aplicar color personalizado
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 27, 42); // azul Windows
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Ajuste de columnas
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Bordes y líneas
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.LightGray;

            //Seleccionar toda la fila al hacer click
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }
    }
}
