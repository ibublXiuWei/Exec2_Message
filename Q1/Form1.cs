using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Timelabel.Text = string.Empty;
		}

		private void Nowbutton_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			GetTime(now);
			string time = GetTime(now) + now.ToString("yyyy/MM/dd HH:mm:ss");
			Timelabel.Text = time;
		}

		private void Secondbutton_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			GetTime(now);
			string time = GetTime(now) +"\r\n" +now.ToString("yyyy/MM/dd HH:mm:ss");
			Timelabel.Text = time;
		}
		private string GetTime(DateTime now)
		{
			string hour = now.ToString("HH");
			int.TryParse(hour, out int hey);
			if (hey < 12)
			{
				string word = "早安";
				return word;
			}
			if (hey < 18)
			{
				string word = "午安";
				return word;
			}
			else
			{
				string word = "晚安";
				return word;
			}

		}
	}
}
