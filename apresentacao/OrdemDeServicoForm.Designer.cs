namespace SmartSolutionSystem
{
    partial class OrdemDeServicoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdemDeServicoForm));
            this.valorTxt = new System.Windows.Forms.TextBox();
            this.descricaoTxt = new System.Windows.Forms.TextBox();
            this.clienteTxt = new System.Windows.Forms.TextBox();
            this.aparelhotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.senhaLb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cadastrarBt = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eletronicos = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // valorTxt
            // 
            this.valorTxt.Location = new System.Drawing.Point(459, 264);
            this.valorTxt.Name = "valorTxt";
            this.valorTxt.Size = new System.Drawing.Size(198, 20);
            this.valorTxt.TabIndex = 33;
            // 
            // descricaoTxt
            // 
            this.descricaoTxt.Location = new System.Drawing.Point(459, 205);
            this.descricaoTxt.Name = "descricaoTxt";
            this.descricaoTxt.Size = new System.Drawing.Size(198, 20);
            this.descricaoTxt.TabIndex = 32;
            // 
            // clienteTxt
            // 
            this.clienteTxt.Location = new System.Drawing.Point(177, 260);
            this.clienteTxt.Name = "clienteTxt";
            this.clienteTxt.Size = new System.Drawing.Size(198, 20);
            this.clienteTxt.TabIndex = 31;
            // 
            // aparelhotxt
            // 
            this.aparelhotxt.Location = new System.Drawing.Point(177, 205);
            this.aparelhotxt.Name = "aparelhotxt";
            this.aparelhotxt.Size = new System.Drawing.Size(198, 20);
            this.aparelhotxt.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(311, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 153);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Valor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 23;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(173, 175);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(177, 24);
            this.nome.TabIndex = 22;
            this.nome.Text = "Aparelho Eletrônico";
            this.nome.Click += new System.EventHandler(this.nome_Click);
            // 
            // senhaLb
            // 
            this.senhaLb.AutoSize = true;
            this.senhaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLb.Location = new System.Drawing.Point(361, 200);
            this.senhaLb.Name = "senhaLb";
            this.senhaLb.Size = new System.Drawing.Size(0, 24);
            this.senhaLb.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar});
            this.dataGridView1.Location = new System.Drawing.Point(177, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 86);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            // 
            // cadastrarBt
            // 
            this.cadastrarBt.Location = new System.Drawing.Point(545, 416);
            this.cadastrarBt.Name = "cadastrarBt";
            this.cadastrarBt.Size = new System.Drawing.Size(112, 29);
            this.cadastrarBt.TabIndex = 34;
            this.cadastrarBt.Text = "Cadastrar";
            this.cadastrarBt.UseVisualStyleBackColor = true;
            this.cadastrarBt.Click += new System.EventHandler(this.cadastrarBt_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eletronicos,
            this.adicionarNovoToolStripMenuItem,
            this.usuáriosToolStripMenuItem,
            this.telaPrincipalToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "OS";
            // 
            // eletronicos
            // 
            this.eletronicos.Name = "eletronicos";
            this.eletronicos.Size = new System.Drawing.Size(34, 20);
            this.eletronicos.Text = "OS";
            this.eletronicos.Click += new System.EventHandler(this.eletronicos_Click);
            // 
            // adicionarNovoToolStripMenuItem
            // 
            this.adicionarNovoToolStripMenuItem.Name = "adicionarNovoToolStripMenuItem";
            this.adicionarNovoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.adicionarNovoToolStripMenuItem.Text = "Nova OS";
            this.adicionarNovoToolStripMenuItem.Click += new System.EventHandler(this.adicionarNovoToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // telaPrincipalToolStripMenuItem
            // 
            this.telaPrincipalToolStripMenuItem.Name = "telaPrincipalToolStripMenuItem";
            this.telaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.telaPrincipalToolStripMenuItem.Text = "Tela Principal";
            this.telaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.telaPrincipalToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // OrdemDeServicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cadastrarBt);
            this.Controls.Add(this.valorTxt);
            this.Controls.Add(this.descricaoTxt);
            this.Controls.Add(this.clienteTxt);
            this.Controls.Add(this.aparelhotxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.senhaLb);
            this.Name = "OrdemDeServicoForm";
            this.Text = "OrdemDeServicoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valorTxt;
        private System.Windows.Forms.TextBox descricaoTxt;
        private System.Windows.Forms.TextBox clienteTxt;
        private System.Windows.Forms.TextBox aparelhotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label senhaLb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
        private System.Windows.Forms.Button cadastrarBt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eletronicos;
        private System.Windows.Forms.ToolStripMenuItem adicionarNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}