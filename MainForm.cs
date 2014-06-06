
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PRACTICA_5
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void ResponderClick(object sender, EventArgs e)
		{
			
						int Cont=0;
						
			
			if(this.checkBox3.Checked)
				{
				 Cont = Cont +1;
				 }

			  if(this.radioButton1.Checked)
			  	{
				 Cont = Cont +1;
				}
			
			if(this.numericUpDown1.Text == "31")
			{
				 Cont = Cont +1;
			}
			
			if(this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810")
			{
				 Cont = Cont +1;		
			}
			
						
						


			 System.Windows.Forms.MessageBox.Show("Las respuestas correctas fueron "+ Cont); 
		}
		
		
		
		
	}
}
