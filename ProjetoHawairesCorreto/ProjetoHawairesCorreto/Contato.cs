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
    public partial class Contato : Form
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void Contato_Load(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1  PagIni = new Form1 ();
            PagIni.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
