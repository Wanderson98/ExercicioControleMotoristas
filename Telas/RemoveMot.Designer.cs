namespace Aula80.Telas
{
    partial class RemoveMot
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
            this.btnRemover = new MaterialSkin.Controls.MaterialButton();
            this.txtNome = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(18, 101);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(101, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Digite o Nome";
            // 
            // btnRemover
            // 
            this.btnRemover.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemover.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRemover.Depth = 0;
            this.btnRemover.HighEmphasis = true;
            this.btnRemover.Icon = null;
            this.btnRemover.Location = new System.Drawing.Point(214, 216);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRemover.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRemover.Size = new System.Drawing.Size(89, 36);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRemover.UseAccentColor = false;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtNome
            // 
            this.txtNome.AnimateReadOnly = false;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Depth = 0;
            this.txtNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNome.LeadingIcon = null;
            this.txtNome.Location = new System.Drawing.Point(21, 139);
            this.txtNome.MaxLength = 50;
            this.txtNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(282, 50);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "";
            this.txtNome.TrailingIcon = null;
            // 
            // RemoveMot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 445);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RemoveMot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remover Motorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnRemover;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
    }
}