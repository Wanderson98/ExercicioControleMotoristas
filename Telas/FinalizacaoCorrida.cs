using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Aula80.Entidades;

namespace Aula80.Telas
{
    public partial class FinalizacaoCorrida : MaterialForm
    {
        public Motorista Motorista { get; set; }
        public FinalizacaoCorrida()
        {
            InitializeComponent();
        }
        public FinalizacaoCorrida(Motorista motorista)
        {
            InitializeComponent();
            Motorista = motorista;
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValorCorrida.Text);
            Motorista.FinalizarCorrida(valor);
            this.Close();
        }
    }
}