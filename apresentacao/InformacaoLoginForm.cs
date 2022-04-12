using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartSolutionSystem.controle;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.apresentacao
{
    public partial class InformacaoLoginForm : Form
    {
        public Usuario usuario;
        private bool usuarioCompleted;

        public InformacaoLoginForm()
        {
            InitializeComponent();
        }

        public InformacaoLoginForm(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            if (usuario != null && usuario.informacaoLogin!= null)
            {
                loginTxt.Text = usuario.informacaoLogin.login;
                senhaTxt.Text = usuario.informacaoLogin.senha;
            }
            
        }

        private void InformacaoLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void proximoBt_Click(object sender, EventArgs e)
        {
            if (usuario == null)
            {
                usuario = new Usuario();
            }
            usuarioCompleted = true;


            if (usuario.informacaoLogin == null)
            {
                usuario.informacaoLogin = new InformacaoLogin();
            }

            if (!usuario.informacaoLogin.setLoginIfNotEmpty(loginTxt.Text))
            {
                MessageBox.Show("Informe seu login para concluir o cadastro.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                usuarioCompleted = false;
            }
           

                

                if (!usuario.informacaoLogin.setSenhaIfNotEmpty(senhaTxt.Text))
                {
                    MessageBox.Show("Informe sua senha para concluir o cadastro.", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usuarioCompleted = false;
                }
                else
                {
                if (!senhaTxt.Text.Equals(confirmarSenhaTxt.Text))
                    {
                        MessageBox.Show("O confirmar senha deve ser igual a senha.", "ERRO",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        usuarioCompleted = false;
                    }
                }
            
            

            


            if (usuarioCompleted )
            {
                if (termosCheck.Checked)
                {
                    UsuarioControle controle = new UsuarioControle();
                    controle.cadastrar(usuario);
                    if (controle.mensagem.Equals(""))
                    {
                        if (controle.usuario != null)
                        {
                            MessageBox.Show("Cadastro Realizado com Sucesso!", "Successo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        if (Login.ActiveForm == null)
                        {
                            Login login = new Login();
                            login.Show();
                        }
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(controle.mensagem);
                    }

                    

                }
                else
                {
                    MessageBox.Show("Você deve aceitar os Termos e Condições gerais de uso!", "Warning",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               
            }
        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void voltarBt_Click(object sender, EventArgs e)
        {
            InformacaoPessoalForm informacaoPessoal = new InformacaoPessoalForm(usuario);
            informacaoPessoal.Show();
            this.Close();
        }

        private void termosCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TermosGeraisDeUsoForm termosGeraisDeUsoForm = new TermosGeraisDeUsoForm(usuario);
            termosGeraisDeUsoForm.Show();

            this.Close();
        }
    }
}
