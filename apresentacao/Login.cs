using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartSolutionSystem.apresentacao;
using SmartSolutionSystem.controle;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem
{
    public partial class Login : Form
    {    Usuario usuarioLogado ;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void acessarBt_Click(object sender, EventArgs e)
        {
            LoginControle controle = new LoginControle();
            controle.acessar(loginTxt.Text, senhaTxt.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.usuario != null)
                {
                    MessageBox.Show("Logado com Sucesso", "Entrando",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    usuarioLogado = controle.usuario;

                    RegistroAtividadeControle controleRgistro = new RegistroAtividadeControle();

                    RegistroAtividade novoRegistro = new RegistroAtividade();
                    novoRegistro.horario = DateTime.Now;
                    novoRegistro.usuario = usuarioLogado;
                    novoRegistro.tipoAtivide = TipoAtividade.Login;

                    controleRgistro.cadastrar(novoRegistro);

                   
                    TelaPrincipalForm telaPrincipalForm = new TelaPrincipalForm(usuarioLogado);
                    telaPrincipalForm.Show();

                }
                else
                {
                    MessageBox.Show("Verifique login e senha", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void senhaLb_Click(object sender, EventArgs e)
        {

        }

        private void cadastreSeBt_Click(object sender, EventArgs e)
        {
            InformacaoPessoalForm info = new InformacaoPessoalForm();
            info.Show();
            
        }
    }
}
