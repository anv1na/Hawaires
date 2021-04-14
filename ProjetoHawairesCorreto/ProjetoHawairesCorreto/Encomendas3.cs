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
    public partial class Encomendas3 : Form
    {
        public Encomendas3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Encomendas2  Eco2 = new Encomendas2  ();
            Eco2.Show();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu pedido foi realizado com sucesso!", "Obrigada Pela Prefrência", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form1 Pag = new Form1();
            Pag.Show();

        }
    }
}
