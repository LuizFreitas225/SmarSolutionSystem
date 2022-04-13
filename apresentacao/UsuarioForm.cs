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
using SmartSolutionSystem.dao;
using SmartSolutionSystem.model;

namespace SmartSolutionSystem.apresentacao
{
    public partial class UsuarioForm : Form

    {
        UsuarioControle usuarioControle = new UsuarioControle();
        Usuario usuarioLogado;

        public UsuarioForm(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
            dataGridView1.DataSource = usuarioControle.getUsuariosDTO();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eletronicos_Click(object sender, EventArgs e)
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
            else
            {

                OrdemDeServicoForm ordemDeServicoForm = new OrdemDeServicoForm(usuarioLogado);
                ordemDeServicoForm.Show();
                this.Close();

            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void telaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaPrincipalForm telaPrincipal = new TelaPrincipalForm(usuarioLogado);
            telaPrincipal.Show();
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
