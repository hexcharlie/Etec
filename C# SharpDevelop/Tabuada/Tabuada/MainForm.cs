using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tabuada
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
	
			 int num;

            if (int.TryParse(textBox1.Text, out num))
            {
                listBox1.Items.Clear(); // Limpa a lista antes de adicionar os novos itens

                for (int mult = 1; mult <= 10; mult++)
                {
                    int tab = num * mult;
                    listBox1.Items.Add(tab.ToString()); // Converte o valor inteiro em uma string antes de adicioná-lo
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um número válido.");
            }
        }
    }
}