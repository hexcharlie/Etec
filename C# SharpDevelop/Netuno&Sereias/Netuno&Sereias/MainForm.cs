using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Netuno_Sereias
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{	
			if  (string.IsNullOrWhiteSpace(textBox1.Text) ||
			     string.IsNullOrWhiteSpace(textBox2.Text) ||
			     string.IsNullOrWhiteSpace(textBox3.Text))			     
			{
				MessageBox.Show("Por favor, preencha todos os campos de entrada!!!");
				return;
			}
		
			float altura,largura,comprimento,vol,serv,add,imp,total;
			
			altura = float.Parse(textBox1.Text);
			largura = float.Parse(textBox2.Text);
			comprimento = float.Parse(textBox3.Text);
			
			
			vol = altura * largura * comprimento;
			textBox4.Text = vol.ToString();
			
			serv = vol * 58;
			textBox5.Text = serv.ToString();
			
			add = 0;
			if(vol>=50){
				add = serv * 0.20f;
			}
			if(vol>=200){
				add = serv * 0.40f;
			}
			if(vol<50){
				textBox6.Text = "N/A";
			}
			else
            {
                textBox6.Text = add.ToString();
            }
			
			imp = serv * 0.22f;
			textBox7.Text = imp.ToString();
			
			total = serv + add + imp;
			textBox8.Text = total.ToString();
				
			
			
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
			textBox1.Focus();
			
		}
	}
}
