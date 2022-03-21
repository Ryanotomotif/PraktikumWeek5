using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			listBox_data.Items.Add(textBox_InputData.Text);
			if (textBox_InputData.Text == listBox_data.Items.ToString())
			{
				MessageBox.Show("Input Kembar");
			}
		}

		private void listBox_data_SelectedIndexChanged(object sender, EventArgs e)
		{
			label_output.Text = listBox_data.Text;
		}

		private void btn_cleardata_Click(object sender, EventArgs e)
		{
			listBox_data.Items.Clear();
			textBox_InputData.Clear();
			label_output.ResetText();
		}

		private void radioButton_merah_CheckedChanged(object sender, EventArgs e)
		{
			if (checkbox_aktif.Checked)
			{
				label_output.ForeColor = Color.Red;
			}
			if (checkbox_aktif.Checked == false)
			{
				label_output.ForeColor = Color.Black;
			}

		}

		private void radioButton_biru_CheckedChanged(object sender, EventArgs e)
		{
			if (checkbox_aktif.Checked)
			{
				label_output.ForeColor = Color.Blue;
			}
			if (checkbox_aktif.Checked == false)
			{
				label_output.ForeColor = Color.Black;
			}
		}
	}
}
