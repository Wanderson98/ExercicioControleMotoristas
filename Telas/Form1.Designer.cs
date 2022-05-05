namespace Aula80.Telas
{
    partial class Form1
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
            this.ltbRelatorio = new MaterialSkin.Controls.MaterialListBox();
            this.txtBuscaNome = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // ltbRelatorio
            // 
            this.ltbRelatorio.BackColor = System.Drawing.Color.White;
            this.ltbRelatorio.BorderColor = System.Drawing.Color.LightGray;
            this.ltbRelatorio.Depth = 0;
            this.ltbRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ltbRelatorio.Location = new System.Drawing.Point(35, 105);
            this.ltbRelatorio.MouseState = MaterialSkin.MouseState.HOVER;
            this.ltbRelatorio.Name = "ltbRelatorio";
            this.ltbRelatorio.SelectedIndex = -1;
            this.ltbRelatorio.SelectedItem = null;
            this.ltbRelatorio.Size = new System.Drawing.Size(493, 303);
            this.ltbRelatorio.TabIndex = 0;
            // 
            // txtBuscaNome
            // 
            this.txtBuscaNome.AnimateReadOnly = false;
            this.txtBuscaNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscaNome.Depth = 0;
            this.txtBuscaNome.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscaNome.LeadingIcon = null;
            this.txtBuscaNome.Location = new System.Drawing.Point(35, 466);
            this.txtBuscaNome.MaxLength = 50;
            this.txtBuscaNome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscaNome.Multiline = false;
            this.txtBuscaNome.Name = "txtBuscaNome";
            this.txtBuscaNome.Size = new System.Drawing.Size(259, 50);
            this.txtBuscaNome.TabIndex = 1;
            this.txtBuscaNome.Text = "";
            this.txtBuscaNome.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(32, 444);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(172, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Digite Nome para Busca";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSize = false;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(319, 466);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscar.Size = new System.Drawing.Size(93, 50);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 547);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtBuscaNome);
            this.Controls.Add(this.ltbRelatorio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relátorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox ltbRelatorio;
        private MaterialSkin.Controls.MaterialTextBox txtBuscaNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
    }
}