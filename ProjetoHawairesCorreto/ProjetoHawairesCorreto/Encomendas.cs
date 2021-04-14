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
    public partial class Encomendas : Form
    {
        public Encomendas()
        {
            InitializeComponent();
        }

        private void btnencomendar_Click(object sender, EventArgs e)
        {

            Encomendas2  End = new Encomendas2();
            End.Show();  
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Form1  PagIni = new Form1 ();
            PagIni.Show();
        }

        private void btnmais_Click(object sender, EventArgs e)
        {
            double quantidade = Convert.ToDouble(cboQuant.Text);
            double produto;
            double preco;
            double add = Convert.ToDouble(cboQuantAdd.Text);
            
            //Fazer as linhas de programação dos produtos - case

            
                    preco = quantidade * produto;


                    // adicionar um "nada" - adicionais
                    if (checkAbacaxi.Checked == true)
                    {
                        preco = preco + (2 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkBanana.Checked == true)
                    {
                        preco = preco + (2 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkCoco.Checked == true)
                    {
                        preco = preco + (4 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkHort.Checked == true)
                    {
                        preco = preco + (3 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkCalda.Checked == true)
                    {
                        preco = preco + (4 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkGranola.Checked == true)
                    {
                        preco = preco + (3 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkMorango.Checked == true)
                    {
                        preco = preco + (4 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkKiwi.Checked == true)
                    {
                        preco = preco + (5 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }

                    if (checkUva.Checked == true)
                    {
                        preco = preco + (3 * add);
                        txtPreco.Text = preco.ToString();
                    }
                    else
                    {
                        preco = preco;
                    }
        }

        private void Encomendas_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtPreco.Clear(); // limpa a text do preco 
            txtNome.Clear();
            checkAbacaxi.Checked = false; // Transforma a checkBox em falsa, limpando-a 
            checkBanana.Checked = false;
            checkCoco.Checked = false;
            checkHort.Checked = false;
            checkCalda.Checked = false;
            checkGranola.Checked = false;
            checkMorango.Checked = false;
            checkKiwi.Checked = false;
            checkUva.Checked = false;
            chkBalaHav.Checked = false;
            chkBananaSplit.Checked = false;
            chkBoloAbacaxi.Checked = false;
            chkBoloCoco.Checked = false;
            chkBoloGoiaba.Checked = false;
            chkBombomTruf.Checked = false;
            chkBrigadeiroAbacaxi.Checked = false;
            chkBrigadeiroBanana.Checked = false;
            chkCakeAbacaxi.Checked = false;
            chkCakeCoco.Checked = false;
            chkEspetinhoFrutas.Checked = false;
            chkFondue.Checked = false;
            chkGelado.Checked = false;
            chkMil.Checked = false;
            chkMix.Checked = false;
            chkMousse.Checked = false;
            chkPave.Checked = false;
            chkPonche.Checked = false;
            chkSorveteAbacaxi.Checked = false;
            chkSorveteBanana.Checked = false;
            chkSorveteCoco.Checked = false;
            chkSorveteGoiaba.Checked = false;
            chkSorveteHula.Checked = false;
            chkTortaAbacaxi.Checked = false;
            cboQuant.Text = "";   // Deixa a ComboBox como vazia, limpando-a
            cboQuantAdd.Text = "";
            txtNome.Focus();  // Faz o cursor voltar para a text indicada
        }

        private void lstProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
