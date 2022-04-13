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
    public partial class InformacaoPessoalForm : Form
    {
        Usuario usuario ;
        bool usuarioCompleted = false;
        public InformacaoPessoalForm()
        {
            InitializeComponent();
        }
        public InformacaoPessoalForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

             isContaEmpresarialCheck.ThreeState = usuario.isPessoaJuridica;

            nometxt.Text = usuario.informacaoPessoal.nome;
            cpfTxt.Text = usuario.informacaoPessoal.cpf;
            telefoneTxt.Text = usuario.informacaoPessoal.telefone;
            cnpjTxt.Text = usuario.informacaoPessoal.cnpj;





           
        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void is_conta_empresarial_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( usuario == null)
            {
                usuario = new Usuario();
            }
            usuarioCompleted = true;

            usuario.isPessoaJuridica = isContaEmpresarialCheck.Checked;

            if(usuario.informacaoPessoal == null)
            {
                usuario.informacaoPessoal = new InformacaoPessoal();
            }

            if (! usuario.informacaoPessoal.setNomeIfNotEmpty(nometxt.Text))
            {
                MessageBox.Show("Informe seu nome para continuar.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                usuarioCompleted = false;
            }
            if (!usuario.informacaoPessoal.setTelefoneIfNotEmpty(telefoneTxt.Text))
            {
                MessageBox.Show("Informe seu telefone para continuar.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioCompleted = false;
            }

            if (usuario.isPessoaJuridica)
            {
                if (!usuario.informacaoPessoal.setCnpjIfNotEmpty(cnpjTxt.Text))
                {
                    MessageBox.Show("Informe seu CNPJ para confirmar sua conta empresarial.", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuarioCompleted = false;
                }
            }
            else
            {
                if (!usuario.informacaoPessoal.setCpfIfNotEmpty(cpfTxt.Text))
                {
                    MessageBox.Show("Informe seu CPF para continuar.", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuarioCompleted = false;
                }
            }


         

            if(usuarioCompleted != false)
            {
                

                EnderecoForm enderecoForm = new EnderecoForm(usuario);
                enderecoForm.Show();
                this.Close();
            }

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cnpjTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpfTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefoneTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void senhaLb_Click(object sender, EventArgs e)
        {

        }
    }
}
