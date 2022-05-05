using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Aula80.Entidades
{
    public class Motorista
    {
        public string Nome { get; set; }
        public bool StatusOn { get; set; }
        public bool StatusViagem { get; set; }
        public int NumeroViagens { get; set; }
        public double ValorDoDia { get; set; }

        public Motorista(string nome)
        {
            Nome = nome;
            StatusOn = false;
            StatusViagem = false;
            NumeroViagens = 0;
            ValorDoDia = 0.0;
        }

        public void FinalizarCorrida(double valor)
        {
            ValorDoDia += valor;
            NumeroViagens++;
        }
        public static void AddMotorista(string nome, List<Motorista> motoristas)
        {
            motoristas.Add(new Motorista(nome));
        }
        public static int RemoveMotorista(string nome, List<Motorista> motoristas)
        {
            
            try
            {
                int posicao = motoristas.FindIndex(m => m.Nome == nome);
                motoristas.RemoveAt(posicao);
                return 0;
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show("Exclusão Não Realizada!", false);
                return 1;
            }
            
        }
        public override string ToString()
        {
            return $"{Nome} - Número de Viagens: {NumeroViagens}, Valor Total: R$ {ValorDoDia:F2}";
        }
    }

    internal class MotoristaRepositorio
    {
        public static List<Motorista> InicializarMotorista()
        {
            List<Motorista> list = new List<Motorista>();

            list.Add(new Motorista("Samuel"));
            list.Add(new Motorista("Pedro"));
            list.Add(new Motorista("Wanderson"));
            list.Add(new Motorista("João Paulo"));


            return list;
        }
    }


}
