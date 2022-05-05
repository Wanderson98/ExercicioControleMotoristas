namespace Aula80.Telas
{
    partial class AddMotorista
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.btnAdicionarMotorista = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(26, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(119, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Digite Seu Nome";
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(18, 127);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 50);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            // 
            // btnAdicionarMotorista
            // 
            this.btnAdicionarMotorista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionarMotorista.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdicionarMotorista.Depth = 0;
            this.btnAdicionarMotorista.HighEmphasis = true;
            this.btnAdicionarMotorista.Icon = null;
            this.btnAdicionarMotorista.Location = new System.Drawing.Point(200, 199);
            this.btnAdicionarMotorista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdicionarMotorista.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdicionarMotorista.Name = "btnAdicionarMotorista";
            this.btnAdicionarMotorista.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdicionarMotorista.Size = new System.Drawing.Size(98, 36);
            this.btnAdicionarMotorista.TabIndex = 2;
            this.btnAdicionarMotorista.Text = "Adicionar";
            this.btnAdicionarMotorista.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdicionarMotorista.UseAccentColor = false;
            this.btnAdicionarMotorista.UseVisualStyleBackColor = true;
            this.btnAdicionarMotorista.Click += new System.EventHandler(this.btnAdicionarMotorista_Click);
            // 
            // AddMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 423);
            this.Controls.Add(this.btnAdicionarMotorista);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.materialLabel1);
            this.Name = "AddMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Motorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialButton btnAdicionarMotorista;
    }
}