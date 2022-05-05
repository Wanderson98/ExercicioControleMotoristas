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
    public partial class Form1 : MaterialForm
    {
        private List<Motorista> Motoristas = new List<Motorista>();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(List<Motorista> motoristas)
        {
            InitializeComponent();
            Motoristas = motoristas;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Motorista motorista in Motoristas)
            {
                ltbRelatorio.AddItem(motorista.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Motorista> motoristas = Motoristas.FindAll(x => x.Nome.Contains(txtBuscaNome.Text));
            if(motoristas.Count < 1)
            {
                MaterialMessageBox.Show("Nenhum motorista encontrado! ", "Erro Busca", MessageBoxButtons.OK, false);
            }
            else
            {
                ltbRelatorio.Items.Clear();
                foreach(Motorista motorista in motoristas)
                {
                    ltbRelatorio.AddItem(motorista.ToString());
                }
            }
        }
    }
}
