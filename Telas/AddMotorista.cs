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
    public partial class AddMotorista : MaterialForm
    {
        private List<Motorista> Motoristas = new List<Motorista>();
        public AddMotorista()
        {
            InitializeComponent();
        }
        public AddMotorista(List<Motorista> motoristas)
        {
            InitializeComponent();
            Motoristas = motoristas;
        }

        private void btnAdicionarMotorista_Click(object sender, EventArgs e)
        {
            DialogResult = MaterialMessageBox.Show("Finalizar Cadastro? ", "Cadastro", MessageBoxButtons.YesNo, false);
            if (DialogResult == DialogResult.Yes)
            {
                Motorista.AddMotorista(txtNome.Text, Motoristas);
                //this.Close();
            }
            else
            {
                txtNome.Text = null;
            }

            
        }
    }
}
