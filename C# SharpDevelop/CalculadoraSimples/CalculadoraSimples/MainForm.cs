using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CalculadoraSimples
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			int n1,n2,soma;
			n1 = int.Parse(textBox1.Text);
			n1 = int.Parse(textBox1.Text);
			
			soma = n1 + n2;
			
			textBox3.Text = soma.ToString;
			
			
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox1.Focus();
			
		}
	}
}
