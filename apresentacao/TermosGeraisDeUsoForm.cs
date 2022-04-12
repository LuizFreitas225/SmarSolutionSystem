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
    public partial class TermosGeraisDeUsoForm : Form
    {
        public Usuario usuario;

        public TermosGeraisDeUsoForm()
        {
            InitializeComponent();
        }
        public TermosGeraisDeUsoForm(Usuario usuario)  
        {
            if( usuario != null)
            {
                this.usuario = usuario;
            }
            
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InformacaoLoginForm informacaoLoginForm = new InformacaoLoginForm(usuario);
            informacaoLoginForm.Show();
            this.Close();

        }
    }
}
