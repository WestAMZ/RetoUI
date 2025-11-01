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

namespace RetoUI
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            LoadCustomers();
            setGridStiles(this.gridview);
        }

        private void LoadCustomers()
        {
            var customer = DataReader.Read().data.customers.Select(x => (new { id = x.id, Nombre = x.name, Celular = x.cellphone })).ToList();
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
