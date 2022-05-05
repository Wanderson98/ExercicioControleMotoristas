namespace Aula80.Telas
{
    partial class FinalizacaoCorrida
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
            this.txtValorCorrida = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtValorCorrida
            // 
            this.txtValorCorrida.AllowPromptAsInput = true;
            this.txtValorCorrida.AnimateReadOnly = false;
            this.txtValorCorrida.AsciiOnly = false;
            this.txtValorCorrida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtValorCorrida.BeepOnError = false;
            this.txtValorCorrida.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtValorCorrida.Depth = 0;
            this.txtValorCorrida.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtValorCorrida.HidePromptOnLeave = false;
            this.txtValorCorrida.HideSelection = true;
            this.txtValorCorrida.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtValorCorrida.LeadingIcon = null;
            this.txtValorCorrida.Location = new System.Drawing.Point(51, 111);
            this.txtValorCorrida.Mask = "";
            this.txtValorCorrida.MaxLength = 32767;
            this.txtValorCorrida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtValorCorrida.Name = "txtValorCorrida";
            this.txtValorCorrida.PasswordChar = '\0';
            this.txtValorCorrida.PrefixSuffixText = null;
            this.txtValorCorrida.PromptChar = '_';
            this.txtValorCorrida.ReadOnly = false;
            this.txtValorCorrida.RejectInputOnFirstFailure = false;
            this.txtValorCorrida.ResetOnPrompt = true;
            this.txtValorCorrida.ResetOnSpace = true;
            this.txtValorCorrida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValorCorrida.SelectedText = "";
            this.txtValorCorrida.SelectionLength = 0;
            this.txtValorCorrida.SelectionStart = 0;
            this.txtValorCorrida.ShortcutsEnabled = true;
            this.txtValorCorrida.Size = new System.Drawing.Size(250, 48);
            this.txtValorCorrida.SkipLiterals = true;
            this.txtValorCorrida.TabIndex = 0;
            this.txtValorCorrida.TabStop = false;
            this.txtValorCorrida.Text = "Digite o Valor da Corrida";
            this.txtValorCorrida.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtValorCorrida.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtValorCorrida.TrailingIcon = null;
            this.txtValorCorrida.UseSystemPasswordChar = false;
            this.txtValorCorrida.ValidatingType = null;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.HighEmphasis = true;
            this.btnFinalizar.Icon = null;
            this.btnFinalizar.Location = new System.Drawing.Point(103, 190);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalizar.Size = new System.Drawing.Size(94, 36);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalizar.UseAccentColor = false;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FinalizacaoCorrida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 315);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.txtValorCorrida);
            this.Name = "FinalizacaoCorrida";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalizacaoCorrida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialMaskedTextBox txtValorCorrida;
        private MaterialSkin.Controls.MaterialButton btnFinalizar;
    }
}