using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Invertendo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
	
			string palavra = textBox1.Text.ToLower();
			char[] invert = new char[palavra.Length];
			for (int i = 0; i < palavra.Length; i++) {
				invert[i] = palavra[palavra.Length - 1 - i];
			}
			string palavrainvert = new string(invert);
			
			string vogais = "";
			foreach (char c in palavrainvert) {
				if ("aeiou".IndexOf(c) == -1) {
					vogais += c;
				}
			}
			
			listBox1.Items.Add(vogais);
						
		}
	}
}
