using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Admin;

namespace WindowsPubs
{
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar();
        }

        private void btnFiltrarCiudad_Click(object sender, EventArgs e)
        {
            string City = Convert.ToString(txtCity.Text);
            gridPublisher.DataSource = AdmPublisher.Listar(City);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            gridPublisher.DataSource = AdmPublisher.Listar();
        }

        private void btnFiltrar2_Click(object sender, EventArgs e)
        {
            string City = Convert.ToString(txtCity.Text);
            string State = Convert.ToString(txtFiltrar2.Text);
            gridPublisher.DataSource = AdmPublisher.Listar(City,State);
        }

        private void btnFiltrar3_Click(object sender, EventArgs e)
        {
            string City = Convert.ToString(txtCity.Text);
            string State = Convert.ToString(txtFiltrar2.Text);
            string Country = Convert.ToString(textBox1.Text);
            gridPublisher.DataSource = AdmPublisher.Listar(City, State, Country);
        }
    }
}
