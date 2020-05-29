using System;
using System.Windows.Forms;

namespace Microsoft95Keygen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string _path;
		private bool _save;
		private int _amount = 1;
		private KeyType _keyType = KeyType.Cd;

		private void checkBoxSave_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxSave.Checked)
			{
				_save = true;
				textBoxPath.Enabled = true;
				numericUpDownAmount.Enabled = true;
				buttonBrowse.Enabled = true;
			}
			else
			{
				_save = false;
				textBoxPath.Enabled = false;
				numericUpDownAmount.Enabled = false;
				buttonBrowse.Enabled = false;
			}
		}

		private void buttonBrowse_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
			_path = saveFileDialog1.FileName;
			textBoxPath.Text = _path;
		}
		
		private void textBoxPath_TextChanged(object sender, EventArgs e)
			=> _path = textBoxPath.Text;

		private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
			=> _amount = (int)numericUpDownAmount.Value;

		private void radioButtonCd_CheckedChanged(object sender, EventArgs e)
			=> _keyType = radioButtonCd.Checked ? KeyType.Cd : KeyType.Oem;

		private void buttonGen_Click(object sender, EventArgs e)
		{
			textBoxOut.Text = _keyType == KeyType.Oem
								? OemGen.Keygen(_amount, _save, _path)[0].ToString()
								: CdGen.Keygen(_amount, _save, _path)[0].ToString();
		}
	}

	enum KeyType
	{
		Oem,
		Cd
	}
}