using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.apresentacao
{
    public partial class EnderecoForm : Form
    {
        Usuario usuario;
        bool usuarioCompleted;
        public EnderecoForm()
        {
            InitializeComponent();
        }
        public EnderecoForm(Usuario usuario,bool withEndereco)
        {
            InitializeComponent();
            if (withEndereco)
            {
                cepTxt.Text = usuario.endereco.cep;
                enderecoTxt.Text = usuario.endereco.endereco;
                complementoTxt.Text = usuario.endereco.complemento;
                cidadeTxt.Text = usuario.endereco.cidade;
                bairroTxt.Text = usuario.endereco.bairro;
                ufTxt.Text = usuario.endereco.uf;
            }
            this.usuario = usuario;
         
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ws = new CorreiosApi.AtendeClienteClient();

            try
            {
                var resultado = ws.consultaCEP(cepTxt.Text);
                enderecoTxt.Text = resultado.end;
                complementoTxt.Text = resultado.complemento2;
                cidadeTxt.Text = resultado.cidade;
                bairroTxt.Text = resultado.bairro;
                ufTxt.Text = resultado.uf;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cnpjTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltarBt_Click(object sender, EventArgs e)
        {
            InformacaoPessoalForm informacaoPessoalForm  = new InformacaoPessoalForm(usuario);
            informacaoPessoalForm.Show();
            this.Close();
        }

        private void proximoBt_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                usuario = new Usuario();
            }
            usuarioCompleted = true;

            if (usuario.endereco == null)
            {
                usuario.endereco = new Endereco();
            }

            if (!usuario.endereco.setCepIfNotEmpty(cepTxt.Text))
            {
                MessageBox.Show("Informe seu cep para continuar.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                usuarioCompleted = false;
            }
            if (!usuario.endereco.setBairroIfNotEmpty(bairroTxt.Text))
            {
                MessageBox.Show("Informe seu bairro para continuar.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioCompleted = false;
            }

            if (!usuario.endereco.setUfIfNotEmpty(ufTxt.Text))
            {
                MessageBox.Show("Informe seu UF para continuar.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioCompleted = false;
            }

            if (!usuario.endereco.setCidadeIfNotEmpty(cidadeTxt.Text))
            {
                MessageBox.Show("Informe sua cidade para continuar.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioCompleted = false;
            }

            if (!usuario.endereco.setEnderecoifNotEmpty(enderecoTxt.Text))
            {
                MessageBox.Show("Informe seu endereço para continuar.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioCompleted = false;
            }

            usuario.endereco.setComplementoifNotEmpty(complementoTxt.Text);
            






            if (usuarioCompleted != false)
            {


                InformacaoLoginForm informacaoLogin = new InformacaoLoginForm(usuario);
                informacaoLogin.Show();
                this.Close();
            }

        }
    }
}
