using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace distCid
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();

		}
				
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{			
			
			float A,B,P1,P2,P3,distTotal,dist;
			
			A = float.Parse (textBox1.Text);
			B = float.Parse (textBox2.Text);
			
			distTotal = B-A;
			dist = distTotal/4;
			P1 = A+dist;
			P2 = P1+dist;
			P3 = P2+dist;
			
			textBox3.Text = P1.ToString();
			textBox4.Text = P2.ToString();
			textBox5.Text = P3.ToString();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();
			
		}

	}
}
