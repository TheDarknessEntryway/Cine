namespace Cine
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iXORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingressosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iXORToolStripMenuItem,
            this.acessoToolStripMenuItem,
            this.ingressosToolStripMenuItem,
            this.cardápioToolStripMenuItem,
            this.acessoFuncionáriosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 6, 4, 6);
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1164, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iXORToolStripMenuItem
            // 
            this.iXORToolStripMenuItem.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iXORToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.iXORToolStripMenuItem.Name = "iXORToolStripMenuItem";
            this.iXORToolStripMenuItem.Size = new System.Drawing.Size(76, 28);
            this.iXORToolStripMenuItem.Text = "YXOR";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessoToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.acessoToolStripMenuItem.Text = "Filmes";
            // 
            // ingressosToolStripMenuItem
            // 
            this.ingressosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingressosToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.ingressosToolStripMenuItem.Name = "ingressosToolStripMenuItem";
            this.ingressosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ingressosToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.ingressosToolStripMenuItem.Text = "Ingressos";
            // 
            // cardápioToolStripMenuItem
            // 
            this.cardápioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardápioToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.cardápioToolStripMenuItem.Name = "cardápioToolStripMenuItem";
            this.cardápioToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.cardápioToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
            this.cardápioToolStripMenuItem.Text = "Cardápio";
            // 
            // acessoFuncionáriosToolStripMenuItem
            // 
            this.acessoFuncionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.cadastroToolStripMenuItem});
            this.acessoFuncionáriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acessoFuncionáriosToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.acessoFuncionáriosToolStripMenuItem.Name = "acessoFuncionáriosToolStripMenuItem";
            this.acessoFuncionáriosToolStripMenuItem.Padding = new System.Windows.Forms.Padding(20, 3, 20, 0);
            this.acessoFuncionáriosToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.acessoFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(161, 28);
            this.acessoFuncionáriosToolStripMenuItem.Text = "Acesso Funcionários";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(962, 12);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 1;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(893, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cine.Properties.Resources.editfront;
            this.ClientSize = new System.Drawing.Size(1164, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iXORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingressosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardápioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label1;
    }
}

