namespace SmartSolutionSystem
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginLb = new System.Windows.Forms.Label();
            this.senhaLb = new System.Windows.Forms.Label();
            this.loginTxt = new System.Windows.Forms.TextBox();
            this.senhaTxt = new System.Windows.Forms.TextBox();
            this.acessarBt = new System.Windows.Forms.Button();
            this.cadastreSeBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginLb
            // 
            this.LoginLb.AutoSize = true;
            this.LoginLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLb.Location = new System.Drawing.Point(269, 188);
            this.LoginLb.Name = "LoginLb";
            this.LoginLb.Size = new System.Drawing.Size(57, 24);
            this.LoginLb.TabIndex = 0;
            this.LoginLb.Text = "Login";
            // 
            // senhaLb
            // 
            this.senhaLb.AutoSize = true;
            this.senhaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senhaLb.Location = new System.Drawing.Point(269, 266);
            this.senhaLb.Name = "senhaLb";
            this.senhaLb.Size = new System.Drawing.Size(65, 24);
            this.senhaLb.TabIndex = 1;
            this.senhaLb.Text = "Senha";
            this.senhaLb.Click += new System.EventHandler(this.senhaLb_Click);
            // 
            // loginTxt
            // 
            this.loginTxt.Location = new System.Drawing.Point(273, 233);
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(228, 20);
            this.loginTxt.TabIndex = 2;
            // 
            // senhaTxt
            // 
            this.senhaTxt.Location = new System.Drawing.Point(273, 309);
            this.senhaTxt.Name = "senhaTxt";
            this.senhaTxt.PasswordChar = '*';
            this.senhaTxt.Size = new System.Drawing.Size(228, 20);
            this.senhaTxt.TabIndex = 3;
            // 
            // acessarBt
            // 
            this.acessarBt.Location = new System.Drawing.Point(247, 389);
            this.acessarBt.Name = "acessarBt";
            this.acessarBt.Size = new System.Drawing.Size(112, 29);
            this.acessarBt.TabIndex = 4;
            this.acessarBt.Text = "Acessar";
            this.acessarBt.UseVisualStyleBackColor = true;
            this.acessarBt.Click += new System.EventHandler(this.acessarBt_Click);
            // 
            // cadastreSeBt
            // 
            this.cadastreSeBt.Location = new System.Drawing.Point(411, 389);
            this.cadastreSeBt.Name = "cadastreSeBt";
            this.cadastreSeBt.Size = new System.Drawing.Size(112, 29);
            this.cadastreSeBt.TabIndex = 5;
            this.cadastreSeBt.Text = "Cadastre-se";
            this.cadastreSeBt.UseVisualStyleBackColor = true;
            this.cadastreSeBt.Click += new System.EventHandler(this.cadastreSeBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 156);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cadastreSeBt);
            this.Controls.Add(this.acessarBt);
            this.Controls.Add(this.senhaTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.senhaLb);
            this.Controls.Add(this.LoginLb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLb;
        private System.Windows.Forms.Label senhaLb;
        private System.Windows.Forms.TextBox loginTxt;
        private System.Windows.Forms.TextBox senhaTxt;
        private System.Windows.Forms.Button acessarBt;
        private System.Windows.Forms.Button cadastreSeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

