using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Temperatura
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			float temp;
			
			temp=float.Parse(textBox1.Text);
			
			if(temp<0){
				label2.Text = "Frio congelante!!";
				pictureBox1.Load("frio.png");
			}
			else if(temp>=0 && temp<=10){
				label2.Text = "Muito Frio!!";
				pictureBox1.Load("frio.png");
			}
			else if(temp>10 && temp<=18){
				label2.Text = "Frio!!";
				pictureBox1.Load("frio.png");
			}
			else if(temp>18 && temp<=24){
				label2.Text = "Agradável!!";
				pictureBox1.Load("sol.png");
			}
			else if(temp>24 && temp<=32){
				label2.Text = "Calor!!";
				pictureBox1.Load("sol.png");
			}
			else if(temp>32 && temp<=38){
				label2.Text = "Muito quente!!";
				pictureBox1.Load("calor.png");
			}
			else{
				label2.Text = "Calor escaldante!!";
				pictureBox1.Load("calor.png");
			}
		}
	}
}
