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
    public partial class RemoveMot : MaterialForm
    {
        private List<Motorista> Motoristas = new List<Motorista>();
        public RemoveMot()
        {
            InitializeComponent();
        }
        public RemoveMot(List<Motorista> motoristas)
        {
            InitializeComponent();
            Motoristas = motoristas;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            DialogResult = MaterialMessageBox.Show("Deseja Remover este Motorista? ", "Remover", MessageBoxButtons.YesNo, false);
            if (DialogResult == DialogResult.Yes)
            {
               int resposta = Motorista.RemoveMotorista(txtNome.Text, Motoristas);
               if(resposta == 0)
                {
                    MaterialMessageBox.Show("Exclusão Realizada! ", false);
                }
              
              
            }
            else
            {
                txtNome.Text = null;
            }
        }
    }
}
