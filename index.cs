using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace islamscroll
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random r = new Random();
			int rInt = r.Next(0, 10);

			if (rInt == 0)
			{
				label2.Text = "Allah is All hearing";
				Controls.Add(label2);
			}

			if (rInt == 1)
			{
				label2.Text = "“ My mercy encompasses all things”";
				Controls.Add(label2);
			}

			if (rInt == 2)
			{
				label2.Text = "' So verily, with the hardship, there is a relief.'";
				Controls.Add(label2);
			}

			if (rInt == 3)
			{
				label2.Text = "' And whoever relies upon Allah – then He is sufficient for him.' ";
				Controls.Add(label2);
			}

			if (rInt == 4)
			{
				label2.Text = "'The truth is from your Lord, so do not be among the doubters' ";
				Controls.Add(label2);
			}
			if (rInt == 5)
			{
				label2.Text = "' Do not lose hope, nor be sad' ";
				Controls.Add(label2);
			}
			if (rInt == 6)
			{
				label2.Text = "' Call upon me, I will respond to you' ";
				Controls.Add(label2);
			}
			if (rInt == 7)
			{
				label2.Text = "' If Allah should aid you, no one can overcome you; but if He should forsake you, who is there that can aid you after Him? And upon Allah let the believers rely' ";
				Controls.Add(label2);
			}
			if (rInt == 8)
			{
				label2.Text = "'And Allah is with the doers of good' ";
				Controls.Add(label2);
			}
			if (rInt == 9)
			{
				label2.Text =  "' Do not worship except Allah ; and to parents do good and to relatives, orphans, and the needy. And speak to people good [words] and establish prayer and give zakah.' ";
				Controls.Add(label2);
			}
			if (rInt == 10 )
			{
				label2.Text = "Indeed we belong to Allah, and indeed to Him we will return";
				Controls.Add(label1);
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			Console.WriteLine("' Indeed we belong to Allah, and indeed to Him we will return' ");
		}
	}
}
