using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ABACATE
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			 string s = textBox1.Text;
			 char t = textBox2.Text[0];
             char v = textBox3.Text[0];
             
             if (s.Length == 0)
            {
                MessageBox.Show("Digite uma palavra.");
                return;
            }
             
            listBox1.Items.Clear();
			 			
			 for(int i=0;i<s.Length;i++)
			 {
			 	if(s[i] != t){
			 		listBox1.Items.Add(s[i]);
			 	}
			 	else {
			 		listBox1.Items.Add(v);
			 	}

			 }
			 
		}
	}
}
