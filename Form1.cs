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
using Aula80.Telas;

namespace Aula80
{
    public partial class Form1 : MaterialForm
    {
        List<Motorista> motoristaList = MotoristaRepositorio.InicializarMotorista();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Motorista motorista in motoristaList)
            {
                string statusOn = (motorista.StatusOn) ? "ON" : "OFF";
                string statusViagem = (motorista.StatusViagem) ? "SIM" : "NÃO";
                ltbMotNomes.AddItem(motorista.Nome);
                ltbMotStatus.AddItem(statusOn);
                ltbMotEmViagem.AddItem(statusViagem);
            }
        }

        private void ltbMotStatus_DoubleClick(object sender, EventArgs e)
        {
            if (motoristaList[ltbMotStatus.SelectedIndex].StatusOn)
            {
                DialogResult = MaterialMessageBox.Show("Deseja Ficar Offline? ", "Status Aplicativo", MessageBoxButtons.YesNo, false);
                if (DialogResult == DialogResult.Yes)
                {
                    motoristaList[ltbMotStatus.SelectedIndex].StatusOn = false;
                }
            }
            else
            {
                DialogResult = MaterialMessageBox.Show("Deseja Ficar Online? ", "Status Aplicativo", MessageBoxButtons.YesNo, false);
                if (DialogResult == DialogResult.Yes)
                {
                    motoristaList[ltbMotStatus.SelectedIndex].StatusOn = true;
                }
            }
            RecarregarListBox();
        }

        private void ltbMotEmViagem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (motoristaList[ltbMotEmViagem.SelectedIndex].StatusViagem)
            {
                DialogResult = MaterialMessageBox.Show("Deseja Encerrar Viagem? ", "Status Viagem", MessageBoxButtons.YesNo, false);
                if(DialogResult == DialogResult.Yes)
                {
                    FinalizacaoCorrida finalizacaoCorrida = new FinalizacaoCorrida(motoristaList[ltbMotEmViagem.SelectedIndex]);
                    finalizacaoCorrida.ShowDialog();
                    motoristaList[ltbMotEmViagem.SelectedIndex].StatusViagem = false;
                }
               
            }
            else
            {
                if (motoristaList[ltbMotEmViagem.SelectedIndex].StatusOn)
                {
                    DialogResult = MaterialMessageBox.Show("Deseja Iniciar Viagem? ", "Status Viagem", MessageBoxButtons.YesNo, false);
                    if (DialogResult == DialogResult.Yes)
                    {
                        motoristaList[ltbMotEmViagem.SelectedIndex].StatusViagem = true;
                    }
                }
                else
                {
                    MaterialMessageBox.Show("Motorista Não Está Online! ", "Status Viagem", MessageBoxButtons.OK, false);
                }

            }
            RecarregarListBox();
        }
        public void RecarregarListBox()
        {
            ltbMotNomes.Items.Clear();
            ltbMotEmViagem.Items.Clear();
            ltbMotStatus.Items.Clear();

            foreach (Motorista motorista in motoristaList)
            {
                string statusOn = (motorista.StatusOn) ? "ON" : "OFF";
                string statusViagem = (motorista.StatusViagem) ? "SIM" : "NÃO";
                ltbMotNomes.AddItem(motorista.Nome);
                ltbMotStatus.AddItem(statusOn);
                ltbMotEmViagem.AddItem(statusViagem);
            }
        }

        private void adicionarMotoristaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMotorista addMotorista = new AddMotorista(motoristaList);
            addMotorista.ShowDialog();
            RecarregarListBox();
        }

        private void olharRelatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Form1 form1 = new Telas.Form1(motoristaList);
            form1.ShowDialog();
        }

        private void removerMotoristaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveMot removeMot = new RemoveMot(motoristaList);
            removeMot.ShowDialog();
            RecarregarListBox();
        }
    }
}
