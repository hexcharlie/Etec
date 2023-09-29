using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Radar
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
			     string.IsNullOrWhiteSpace(textBox3.Text)){
			     MessageBox.Show("Por favor, preencha todos os campos de entrada!!.");
				return;
			     }
			float p1,p2,t,vm;
			
			p1 = float.Parse(textBox1.Text);
			p2 = float.Parse(textBox2.Text);
			t = float.Parse(textBox3.Text);
			vm = (p2-p1)/t;
			
			if(vm>80){
				label6.Text = "Multa Aplicada!";
				label7.Text = vm.ToString()+"km/h";
				pictureBox5.Load("multa.png");				
			}
			else{				
				label6.Text = "Sem Multa";
				label7.Text = vm.ToString()+"km/h";
				pictureBox5.Load("semmulta.png");
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox1.Focus();
			
		}
	}
}
