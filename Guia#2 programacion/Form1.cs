using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2_programacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] numeros;
        int tam;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int aux;

            for (int i = 0; i < tam -1; i++)
            {
                for (int j = 0; j < tam -1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        aux = numeros[j];
                        numeros[j] = numeros[j+1];
                        numeros[j + 1] = aux;
                    }
                }

            }
            for (int i = 0; i < tam; i++)
            {
                listBox1.Items.Add("Arreglo[" + i + "] = " + numeros[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[10];
            Random x = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = x.Next(100) + 1;
                listBox1.Items.Add(numeros[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            tam = int.Parse(textBox1.Text);

            numeros= new int[tam];
            Random x = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = x.Next(100) + 1;
                listBox1.Items.Add("Arreglo [" + i + "] = " + numeros[i]);
            }

                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int pos;
            pos = int.Parse(textBox2.Text);
            MessageBox.Show("El elemento del arreglo es: " + numeros[pos]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int me = numeros[0];
            int ma = 0;

            for (int i = 0; i < numeros.Length;i++)
            {
                if (numeros[i] < me)
                {
                    me  = numeros[i];
                }
                if (numeros[i] > ma)
                {
                    ma =  numeros[i];
                }
            }
            MessageBox.Show("MENOR: " + me);
            MessageBox.Show("MAYOR: " + ma);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int su = 0;
            
            for(int i =0;  i < numeros.Length; i++)
            {
                su = su + numeros[i];
            }
            MessageBox.Show("La suma de todos los elementos es: " + su);
        }
    }
}
