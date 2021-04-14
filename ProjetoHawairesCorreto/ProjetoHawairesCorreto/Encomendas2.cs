using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHawairesCorreto
{
    public partial class Encomendas2 : Form
    {
        public Encomendas2()
        {
            InitializeComponent();
        }

        private void btnconcluir_Click(object sender, EventArgs e)
        {
            Encomendas3  Pag = new Encomendas3();
            Pag.Show();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Encomendas Eco1 = new Encomendas ();
            Eco1.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Encomendas2_Load(object sender, EventArgs e)
        {

        }
    }
}
