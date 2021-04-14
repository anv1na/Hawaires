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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            
            Promoções Promo = new Promoções();
            Promo.Show();

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            TodosProdutos Todos = new TodosProdutos();
            Todos.Show();

        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            Contato Contato = new Contato ();
            Contato.Show();

        }

        private void btnEnco_Click(object sender, EventArgs e)
        {
            Encomendas  Enco = new Encomendas ();
            Enco.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
        }
    }
}
