using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia__2_ejercicio_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int cod = 1;
        static int seleccionFila;

        void limpiar()
        {
            textBox4.Text = cod.ToString();
            textBox3.Text = "";
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               if (dataGridView1.RowCount != 0)
               {
                    int indice = dataGridView1.CurrentRow.Index;
                 dataGridView1.Rows[indice].Cells[0].Value = textBox1.Text;
                    dataGridView1.Rows[indice].Cells[1].Value = textBox2.Text;
                    dataGridView1.Rows[indice].Cells[2].Value = textBox3.Text;
                    dataGridView1.Rows[indice].Cells[3].Value = textBox4.Text;
                   MessageBox.Show("Cita modificada, ", "COLEGIO SALESIANO DON BOSCO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
            }
            catch(Exception)
            {
                MessageBox.Show("no hay cita seleccionada", "colegio salesiano don bosco",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiar();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.Text= cod.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object[] agregardato =
            {
                cod.ToString(),
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
            };

            dataGridView1.Rows.Add(agregardato);

            MessageBox.Show("Cita registrada.", "COLEGIO SALESIANO DON BOSCO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            cod++;
            textBox4.Text = cod.ToString();
            limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult men;
            men = MessageBox.Show("¿Desea Salir?", "Colegio Salesiano Don Bosco",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (men == DialogResult.OK)
            {
                Application.Exit();
            }
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int fila = dataGridView1.CurrentCell.RowIndex;
                textBox1.Text = dataGridView1[0, fila].Value.ToString();
                textBox2.Text = dataGridView1[1, fila].Value.ToString();
                textBox3.Text = dataGridView1[2, fila].Value.ToString();
                textBox4.Text = dataGridView1[3, fila].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccionFila >= 0)
                {
                    dataGridView1.Rows.RemoveAt(seleccionFila);
                    MessageBox.Show("Cita eliminada", "Colegio Salesiano Don Bosco",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                    MessageBox.Show("No hay citas", "Colegio Salesiano Don Bosco",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception)
            {
                MessageBox.Show("No hay citas seleccionadas", "Colegio Salesiano Don Bosco",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
