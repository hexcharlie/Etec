using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hippie
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
		void Button1Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBox1.Text) ||
			     string.IsNullOrWhiteSpace(textBox2.Text) ||
			     string.IsNullOrWhiteSpace(textBox3.Text) ||
			     string.IsNullOrWhiteSpace(textBox4.Text) ||
			     string.IsNullOrWhiteSpace(textBox5.Text) ||
			     string.IsNullOrWhiteSpace(textBox6.Text)) {
				MessageBox.Show("Por favor, preencha todos os campos de entrada!!.");
				return;
			}
					
			
			float c1, c2, c3, c1a, c2a, c3a, c1qt, c2qt, c3qt, c1v, c2v, c3v, c1l, c2l, c3l, valorFinal, lucroFinal;
				
				
			c1 = float.Parse(textBox1.Text);
			c2 = float.Parse(textBox2.Text);
			c3 = float.Parse(textBox3.Text);
			c1a = float.Parse(textBox4.Text);
			c2a = float.Parse(textBox5.Text);
			c3a = float.Parse(textBox6.Text);
			
			c1qt = c1 - c1a;
			c2qt = c2 - c2a;
			c3qt = c3 - c3a;
			textBox7.Text = c1qt.ToString();
			textBox10.Text = c2qt.ToString();
			textBox13.Text = c3qt.ToString();
			
			c1v = c1qt * 20;
			c2v = c2qt * 40;
			c3v = c3qt * 60;
			textBox8.Text = c1v.ToString();
			textBox11.Text = c2v.ToString();
			textBox14.Text = c3v.ToString();
			
			c1l = c1qt * 0.18f;
			c2l = c2qt * 0.25f;
			c3l = c3qt * 0.35f;
			textBox9.Text = c1l.ToString();
			textBox12.Text = c2l.ToString();
			textBox15.Text = c3l.ToString();
			
			
			valorFinal = c1v + c2v + c3v;
			textBox16.Text = valorFinal.ToString();
			
			lucroFinal = c1l + c2l + c3l;
			textBox17.Text = lucroFinal.ToString();	
			
			
			
			
		}
		void Button2Click(object sender, EventArgs e)
		{
			
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			textBox6.Clear();
			textBox7.Clear();
			textBox8.Clear();
			textBox9.Clear();
			textBox10.Clear();
			textBox11.Clear();
			textBox12.Clear();
			textBox13.Clear();
			textBox14.Clear();
			textBox15.Clear();
			textBox16.Clear();
			textBox17.Clear();
			textBox1.Focus();
			
			
			
			
			
			
		}
	}
}
