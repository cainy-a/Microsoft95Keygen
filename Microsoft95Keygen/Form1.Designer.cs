namespace Microsoft95Keygen
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.radioButtonCd = new System.Windows.Forms.RadioButton();
			this.radioButtonOem = new System.Windows.Forms.RadioButton();
			this.checkBoxSave = new System.Windows.Forms.CheckBox();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxOut = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.buttonGen = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize) (this.numericUpDownAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(458, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Win 95, Win NT4, Office 95 Keygen";
			// 
			// radioButtonCd
			// 
			this.radioButtonCd.Checked = true;
			this.radioButtonCd.Location = new System.Drawing.Point(12, 46);
			this.radioButtonCd.Name = "radioButtonCd";
			this.radioButtonCd.Size = new System.Drawing.Size(104, 20);
			this.radioButtonCd.TabIndex = 1;
			this.radioButtonCd.TabStop = true;
			this.radioButtonCd.Text = "CD Key";
			this.radioButtonCd.UseVisualStyleBackColor = true;
			this.radioButtonCd.CheckedChanged += new System.EventHandler(this.radioButtonCd_CheckedChanged);
			// 
			// radioButtonOem
			// 
			this.radioButtonOem.Location = new System.Drawing.Point(12, 72);
			this.radioButtonOem.Name = "radioButtonOem";
			this.radioButtonOem.Size = new System.Drawing.Size(104, 20);
			this.radioButtonOem.TabIndex = 1;
			this.radioButtonOem.Text = "OEM Key";
			this.radioButtonOem.UseVisualStyleBackColor = true;
			// 
			// checkBoxSave
			// 
			this.checkBoxSave.Location = new System.Drawing.Point(12, 98);
			this.checkBoxSave.Name = "checkBoxSave";
			this.checkBoxSave.Size = new System.Drawing.Size(120, 24);
			this.checkBoxSave.TabIndex = 2;
			this.checkBoxSave.Text = "Save Keys to file?";
			this.checkBoxSave.UseVisualStyleBackColor = true;
			this.checkBoxSave.CheckedChanged += new System.EventHandler(this.checkBoxSave_CheckedChanged);
			// 
			// textBoxPath
			// 
			this.textBoxPath.Enabled = false;
			this.textBoxPath.Location = new System.Drawing.Point(138, 100);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(189, 20);
			this.textBoxPath.TabIndex = 3;
			this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(138, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Save Path";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// numericUpDownAmount
			// 
			this.numericUpDownAmount.Enabled = false;
			this.numericUpDownAmount.Location = new System.Drawing.Point(414, 100);
			this.numericUpDownAmount.Maximum = new decimal(new int[] {1000, 0, 0, 0});
			this.numericUpDownAmount.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.numericUpDownAmount.Name = "numericUpDownAmount";
			this.numericUpDownAmount.Size = new System.Drawing.Size(56, 20);
			this.numericUpDownAmount.TabIndex = 5;
			this.numericUpDownAmount.Value = new decimal(new int[] {1, 0, 0, 0});
			this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDownAmount_ValueChanged);
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Enabled = false;
			this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.buttonBrowse.Location = new System.Drawing.Point(333, 100);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(75, 19);
			this.buttonBrowse.TabIndex = 6;
			this.buttonBrowse.Text = "Browse...";
			this.buttonBrowse.UseVisualStyleBackColor = true;
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(414, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "Amount to save";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// textBoxOut
			// 
			this.textBoxOut.Location = new System.Drawing.Point(12, 143);
			this.textBoxOut.Name = "textBoxOut";
			this.textBoxOut.ReadOnly = true;
			this.textBoxOut.Size = new System.Drawing.Size(458, 20);
			this.textBoxOut.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 15);
			this.label4.TabIndex = 4;
			this.label4.Text = "Output";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// buttonGen
			// 
			this.buttonGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
			this.buttonGen.Location = new System.Drawing.Point(12, 169);
			this.buttonGen.Name = "buttonGen";
			this.buttonGen.Size = new System.Drawing.Size(458, 35);
			this.buttonGen.TabIndex = 9;
			this.buttonGen.Text = "Make me some keys!!!\r\n";
			this.buttonGen.UseVisualStyleBackColor = true;
			this.buttonGen.Click += new System.EventHandler(this.buttonGen_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.Filter = "Text files|*.txt";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 216);
			this.Controls.Add(this.buttonGen);
			this.Controls.Add(this.textBoxOut);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.buttonBrowse);
			this.Controls.Add(this.numericUpDownAmount);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.checkBoxSave);
			this.Controls.Add(this.radioButtonOem);
			this.Controls.Add(this.radioButtonCd);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Keygen95";
			((System.ComponentModel.ISupportInitialize) (this.numericUpDownAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.Button buttonGen;
		private System.Windows.Forms.CheckBox checkBoxSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numericUpDownAmount;
		private System.Windows.Forms.RadioButton radioButtonCd;
		private System.Windows.Forms.RadioButton radioButtonOem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox textBoxOut;
		private System.Windows.Forms.TextBox textBoxPath;

		#endregion
	}
}