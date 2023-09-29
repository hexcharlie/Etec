/*
 * Created by SharpDevelop.
 * User: Aluno Etec
 * Date: 08/08/2023
 * Time: 19:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace aula3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			button1.BackColor=Color.DeepPink;
			this.BackColor=Color.DeepPink;
			
		}
		
		
		
		
			
		
		
		void Button2Click(object sender, EventArgs e)
		{
			button2.BackColor=Color.DarkSeaGreen;
			this.BackColor=Color.DarkSeaGreen;
			
		}
	}
	}
