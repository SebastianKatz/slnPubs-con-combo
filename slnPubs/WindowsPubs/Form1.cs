using Datos.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Capturar ID de la propiedad seleccionada en el combo
            string categoriaID = Convert.ToString(cbCiudad.SelectedValue);

            if (categoriaID == "")
            {
                gridAutores.DataSource = AdmAuthor.listar();
            }
            else
            {
                gridAutores.DataSource = AdmAuthor.listarPorCiudad(categoriaID);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = AdmAuthor.listarCiudades();
            gridAutores.DataSource = AdmAuthor.listar();
            cbCiudad.DataSource = dataTable;
            cbCiudad.DisplayMember = dataTable.Columns["city"].ToString();
            cbCiudad.ValueMember = dataTable.Columns["city"].ToString();

            /*
            // Agregar una fila al DataTable en memoria
            DataRow dataRow = dataTable.NewRow();
            dataRow["city"] = 0;
            dataRow["city"] = "[All]";
            dataTable.Rows.InsertAt(dataRow, 0);
            */

        }

        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            string City = Convert.ToString(txtCity.Text);
            string State = Convert.ToString(txtFiltrar2.Text);
            gridAutores.DataSource = AdmAuthor.listar(City, State);
        }

        private void btnFiltrarCiudad_Click(object sender, EventArgs e)
        {
            string City = Convert.ToString(txtCity.Text);
            gridAutores.DataSource = AdmAuthor.listar(City);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridAutores.DataSource = AdmAuthor.listar();
        }
    }
}

