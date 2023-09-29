/*
 * Created by SharpDevelop.
 * User: Aluno Etec
 * Date: 17/08/2023
 * Time: 20:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hippie
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.textBox8 = new System.Windows.Forms.TextBox();
			this.textBox9 = new System.Windows.Forms.TextBox();
			this.textBox10 = new System.Windows.Forms.TextBox();
			this.textBox11 = new System.Windows.Forms.TextBox();
			this.textBox12 = new System.Windows.Forms.TextBox();
			this.textBox13 = new System.Windows.Forms.TextBox();
			this.textBox14 = new System.Windows.Forms.TextBox();
			this.textBox15 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox16 = new System.Windows.Forms.TextBox();
			this.textBox17 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(59, 257);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 43);
			this.button1.TabIndex = 6;
			this.button1.Text = "calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(185, 257);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 43);
			this.button2.TabIndex = 7;
			this.button2.Text = "limpar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(336, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 36);
			this.label1.TabIndex = 8;
			this.label1.Text = "C1";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(336, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 36);
			this.label2.TabIndex = 9;
			this.label2.Text = "C2";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(336, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 36);
			this.label3.TabIndex = 10;
			this.label3.Text = "C3";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(411, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 47);
			this.label4.TabIndex = 11;
			this.label4.Text = "QtdVendida";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(629, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(143, 47);
			this.label5.TabIndex = 12;
			this.label5.Text = "R$";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 374);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(163, 47);
			this.label6.TabIndex = 13;
			this.label6.Text = "Venda Total";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 450);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(181, 47);
			this.label7.TabIndex = 14;
			this.label7.Text = "Lucro Total";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(59, 169);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(63, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(141, 169);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(63, 22);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(229, 169);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(63, 22);
			this.textBox3.TabIndex = 2;
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(229, 208);
			this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(63, 22);
			this.textBox6.TabIndex = 3;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(141, 208);
			this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(63, 22);
			this.textBox5.TabIndex = 4;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(59, 208);
			this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(63, 22);
			this.textBox4.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(779, 43);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(143, 47);
			this.label8.TabIndex = 15;
			this.label8.Text = "Lucro";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(419, 110);
			this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox7.Name = "textBox7";
			this.textBox7.ReadOnly = true;
			this.textBox7.Size = new System.Drawing.Size(127, 22);
			this.textBox7.TabIndex = 16;
			// 
			// textBox8
			// 
			this.textBox8.Location = new System.Drawing.Point(583, 110);
			this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox8.Name = "textBox8";
			this.textBox8.ReadOnly = true;
			this.textBox8.Size = new System.Drawing.Size(127, 22);
			this.textBox8.TabIndex = 17;
			// 
			// textBox9
			// 
			this.textBox9.Location = new System.Drawing.Point(755, 110);
			this.textBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox9.Name = "textBox9";
			this.textBox9.ReadOnly = true;
			this.textBox9.Size = new System.Drawing.Size(127, 22);
			this.textBox9.TabIndex = 18;
			// 
			// textBox10
			// 
			this.textBox10.Location = new System.Drawing.Point(419, 185);
			this.textBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox10.Name = "textBox10";
			this.textBox10.ReadOnly = true;
			this.textBox10.Size = new System.Drawing.Size(127, 22);
			this.textBox10.TabIndex = 21;
			// 
			// textBox11
			// 
			this.textBox11.Location = new System.Drawing.Point(583, 185);
			this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox11.Name = "textBox11";
			this.textBox11.ReadOnly = true;
			this.textBox11.Size = new System.Drawing.Size(127, 22);
			this.textBox11.TabIndex = 20;
			// 
			// textBox12
			// 
			this.textBox12.Location = new System.Drawing.Point(755, 185);
			this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox12.Name = "textBox12";
			this.textBox12.ReadOnly = true;
			this.textBox12.Size = new System.Drawing.Size(127, 22);
			this.textBox12.TabIndex = 19;
			// 
			// textBox13
			// 
			this.textBox13.Location = new System.Drawing.Point(419, 257);
			this.textBox13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox13.Name = "textBox13";
			this.textBox13.ReadOnly = true;
			this.textBox13.Size = new System.Drawing.Size(127, 22);
			this.textBox13.TabIndex = 24;
			// 
			// textBox14
			// 
			this.textBox14.Location = new System.Drawing.Point(583, 257);
			this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox14.Name = "textBox14";
			this.textBox14.ReadOnly = true;
			this.textBox14.Size = new System.Drawing.Size(127, 22);
			this.textBox14.TabIndex = 23;
			// 
			// textBox15
			// 
			this.textBox15.Location = new System.Drawing.Point(755, 257);
			this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox15.Name = "textBox15";
			this.textBox15.ReadOnly = true;
			this.textBox15.Size = new System.Drawing.Size(127, 22);
			this.textBox15.TabIndex = 22;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 166);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 36);
			this.label9.TabIndex = 25;
			this.label9.Text = "E";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(12, 206);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(45, 36);
			this.label10.TabIndex = 26;
			this.label10.Text = "S";
			// 
			// textBox16
			// 
			this.textBox16.Location = new System.Drawing.Point(185, 381);
			this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox16.Name = "textBox16";
			this.textBox16.ReadOnly = true;
			this.textBox16.Size = new System.Drawing.Size(127, 22);
			this.textBox16.TabIndex = 27;
			// 
			// textBox17
			// 
			this.textBox17.Location = new System.Drawing.Point(185, 455);
			this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox17.Name = "textBox17";
			this.textBox17.ReadOnly = true;
			this.textBox17.Size = new System.Drawing.Size(127, 22);
			this.textBox17.TabIndex = 28;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(68, 131);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(45, 36);
			this.label11.TabIndex = 29;
			this.label11.Text = "C1";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(148, 131);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 36);
			this.label12.TabIndex = 30;
			this.label12.Text = "C2";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(237, 131);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(45, 36);
			this.label13.TabIndex = 31;
			this.label13.Text = "C3";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 537);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.textBox17);
			this.Controls.Add(this.textBox16);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox13);
			this.Controls.Add(this.textBox14);
			this.Controls.Add(this.textBox15);
			this.Controls.Add(this.textBox10);
			this.Controls.Add(this.textBox11);
			this.Controls.Add(this.textBox12);
			this.Controls.Add(this.textBox9);
			this.Controls.Add(this.textBox8);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "Hippie";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox15;
		private System.Windows.Forms.TextBox textBox14;
		private System.Windows.Forms.TextBox textBox13;
		private System.Windows.Forms.TextBox textBox12;
		private System.Windows.Forms.TextBox textBox11;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBox16;
		private System.Windows.Forms.TextBox textBox17;
	}
}
