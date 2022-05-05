namespace Aula80
{
    partial class Form1
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
            this.ltbMotNomes = new MaterialSkin.Controls.MaterialListBox();
            this.ltbMotStatus = new MaterialSkin.Controls.MaterialListBox();
            this.ltbMotEmViagem = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adicionarMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarMotoristaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olharRelatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerMotoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltbMotNomes
            // 
            this.ltbMotNomes.BackColor = System.Drawing.Color.White;
            this.ltbMotNomes.BorderColor = System.Drawing.Color.LightGray;
            this.ltbMotNomes.Depth = 0;
            this.ltbMotNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ltbMotNomes.Location = new System.Drawing.Point(21, 135);
            this.ltbMotNomes.MouseState = MaterialSkin.MouseState.HOVER;
            this.ltbMotNomes.Name = "ltbMotNomes";
            this.ltbMotNomes.SelectedIndex = -1;
            this.ltbMotNomes.SelectedItem = null;
            this.ltbMotNomes.Size = new System.Drawing.Size(229, 354);
            this.ltbMotNomes.TabIndex = 1;
            // 
            // ltbMotStatus
            // 
            this.ltbMotStatus.BackColor = System.Drawing.Color.White;
            this.ltbMotStatus.BorderColor = System.Drawing.Color.LightGray;
            this.ltbMotStatus.Depth = 0;
            this.ltbMotStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ltbMotStatus.Location = new System.Drawing.Point(278, 135);
            this.ltbMotStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.ltbMotStatus.Name = "ltbMotStatus";
            this.ltbMotStatus.SelectedIndex = -1;
            this.ltbMotStatus.SelectedItem = null;
            this.ltbMotStatus.Size = new System.Drawing.Size(94, 354);
            this.ltbMotStatus.TabIndex = 1;
            this.ltbMotStatus.DoubleClick += new System.EventHandler(this.ltbMotStatus_DoubleClick);
            // 
            // ltbMotEmViagem
            // 
            this.ltbMotEmViagem.BackColor = System.Drawing.Color.White;
            this.ltbMotEmViagem.BorderColor = System.Drawing.Color.LightGray;
            this.ltbMotEmViagem.Depth = 0;
            this.ltbMotEmViagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ltbMotEmViagem.Location = new System.Drawing.Point(397, 135);
            this.ltbMotEmViagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.ltbMotEmViagem.Name = "ltbMotEmViagem";
            this.ltbMotEmViagem.SelectedIndex = -1;
            this.ltbMotEmViagem.SelectedItem = null;
            this.ltbMotEmViagem.Size = new System.Drawing.Size(94, 354);
            this.ltbMotEmViagem.TabIndex = 1;
            this.ltbMotEmViagem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltbMotEmViagem_MouseDoubleClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 113);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Nome";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(275, 113);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(47, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Status";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(394, 113);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Em Viagem";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMotoristaToolStripMenuItem,
            this.relatórioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adicionarMotoristaToolStripMenuItem
            // 
            this.adicionarMotoristaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarMotoristaToolStripMenuItem1,
            this.removerMotoristaToolStripMenuItem});
            this.adicionarMotoristaToolStripMenuItem.Name = "adicionarMotoristaToolStripMenuItem";
            this.adicionarMotoristaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.adicionarMotoristaToolStripMenuItem.Text = "Motoristas";
            // 
            // adicionarMotoristaToolStripMenuItem1
            // 
            this.adicionarMotoristaToolStripMenuItem1.Name = "adicionarMotoristaToolStripMenuItem1";
            this.adicionarMotoristaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.adicionarMotoristaToolStripMenuItem1.Text = "Adicionar Motorista";
            this.adicionarMotoristaToolStripMenuItem1.Click += new System.EventHandler(this.adicionarMotoristaToolStripMenuItem1_Click);
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.olharRelatórioToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // olharRelatórioToolStripMenuItem
            // 
            this.olharRelatórioToolStripMenuItem.Name = "olharRelatórioToolStripMenuItem";
            this.olharRelatórioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.olharRelatórioToolStripMenuItem.Text = "Olhar Relatório";
            this.olharRelatórioToolStripMenuItem.Click += new System.EventHandler(this.olharRelatórioToolStripMenuItem_Click);
            // 
            // removerMotoristaToolStripMenuItem
            // 
            this.removerMotoristaToolStripMenuItem.Name = "removerMotoristaToolStripMenuItem";
            this.removerMotoristaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removerMotoristaToolStripMenuItem.Text = "Remover Motorista";
            this.removerMotoristaToolStripMenuItem.Click += new System.EventHandler(this.removerMotoristaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 553);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ltbMotEmViagem);
            this.Controls.Add(this.ltbMotStatus);
            this.Controls.Add(this.ltbMotNomes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle Motoristas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListBox ltbMotNomes;
        private MaterialSkin.Controls.MaterialListBox ltbMotStatus;
        private MaterialSkin.Controls.MaterialListBox ltbMotEmViagem;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionarMotoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarMotoristaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem olharRelatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerMotoristaToolStripMenuItem;
    }
}

