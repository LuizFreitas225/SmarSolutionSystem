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
    public partial class OrdemDeServicoForm : Form
    {
        UsuarioControle usuarioControle = new UsuarioControle();
        OrdemDeServico ordemDeServico = new OrdemDeServico();
        bool ordemServicCompleted = true;
        Usuario usuarioLogado;

        public OrdemDeServicoForm(Usuario usuario)
        {
            usuarioLogado = usuario;
            InitializeComponent();
            dataGridView1.DataSource = usuarioControle.getUsuariosDTO();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Selecionar")
            {
                UsuarioDTO usu = (UsuarioDTO)dataGridView1.CurrentRow.DataBoundItem;
                ordemDeServico.usuario = usu.AsUsuario();
                clienteTxt.Text = ordemDeServico.usuario.informacaoPessoal.nome;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private TextBox GetValorTxt()
        {
            return valorTxt;
        }

        private void cadastrarBt_Click(object sender, EventArgs e)
        {

            if (ordemDeServico == null)
            {
                ordemDeServico = new OrdemDeServico();
            }
            ordemServicCompleted = true;


            if (ordemDeServico.usuario == null)
            {

                MessageBox.Show("Selecione um cliente da lista abaixo.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                ordemServicCompleted = false;
            }



            if (!ordemDeServico.setEletronicoIfNotEmpty(aparelhotxt.Text))
            {
                MessageBox.Show("Informe o Aparelho Eletrônico para concluir o cadastro.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                ordemServicCompleted = false;
            }

            if (!ordemDeServico.setVDescricaoIfNotEmpty(descricaoTxt.Text))
            {
                MessageBox.Show("Informe a descrição para concluir o cadastro.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                ordemServicCompleted = false;
            }
            if (String.IsNullOrEmpty(valorTxt.Text) )
            {
                
                MessageBox.Show("Informe o campo valor para concluir o cadastro.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                ordemServicCompleted = false;
            }
            else
            {
                try
                {
                    ordemDeServico.valor = float.Parse(valorTxt.Text);
                }
                 catch(Exception ex)
                {
                    MessageBox.Show("Informe um valor valido.", "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ordemServicCompleted = false;
                }
                
            }




            if (ordemServicCompleted)
            {
                
                ordemDeServico.dataCriacao= DateTime.Now;
                ordemDeServico.concluido = false;

                OrdemDeServicoControle controle = new OrdemDeServicoControle();
                controle.cadastrar(ordemDeServico);
                if (controle.mensagem.Equals(""))
                {
                    if (controle.ordemServico != null)
                    {
                        MessageBox.Show("Cadastro Realizado com Sucesso!", "Successo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                    }


                }
                else
                {
                    MessageBox.Show(controle.mensagem);
                }


            }
        }

        private void eletronicos_Click(object sender, EventArgs e)
        {
            ListaOSForm listagemOS = new ListaOSForm(usuarioLogado);
            listagemOS.Show();
            this.Close();
        }

        private void adicionarNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

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
        
    

