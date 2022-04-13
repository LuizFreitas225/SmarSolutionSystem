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
    public partial class TelaPrincipalForm : Form
    {
        Usuario usuarioLogado;
        public TelaPrincipalForm(Usuario usuario)
        {
            usuarioLogado= usuario;
            InitializeComponent();
        }

        private void dsfasdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaOSForm listagemOS = new ListaOSForm(usuarioLogado);
            listagemOS.Show();
            this.Close();
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!usuarioLogado.isAdmin)
            {
                MessageBox.Show("Você deve ser admin para acessar essa tela, solicite a " +
                    "permissão necessária antes de tentar novamente.", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else {

                OrdemDeServicoForm ordemDeServicoForm = new OrdemDeServicoForm(usuarioLogado);
                ordemDeServicoForm.Show();
                this.Close();

            }

           
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (!usuarioLogado.isAdmin)
            {
                MessageBox.Show("Você deve ser admin para acessar essa tela, solicite a " +
                    "permissão necessária antes de tentar novamente.", "ERRO",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                UsuarioForm usuarioForm = new UsuarioForm(usuarioLogado);
                usuarioForm.Show();
                this.Close();

            }
        }

        private void telaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAtividadeControle controle = new RegistroAtividadeControle();

            RegistroAtividade novoRegistro = new RegistroAtividade();
            novoRegistro.horario = DateTime.Now;
            novoRegistro.usuario = usuarioLogado;
            novoRegistro.tipoAtivide = TipoAtividade.Logoff;

            controle.cadastrar(novoRegistro);
            this.Close();
        }
    }
}
