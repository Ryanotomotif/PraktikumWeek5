
namespace PraktikumWeek5
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
			this.label_data = new System.Windows.Forms.Label();
			this.textBox_InputData = new System.Windows.Forms.TextBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.label_koleksi = new System.Windows.Forms.Label();
			this.label_setting = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_output = new System.Windows.Forms.Label();
			this.listBox_data = new System.Windows.Forms.ListBox();
			this.checkbox_aktif = new System.Windows.Forms.CheckBox();
			this.radioButton_merah = new System.Windows.Forms.RadioButton();
			this.radioButton_biru = new System.Windows.Forms.RadioButton();
			this.btn_cleardata = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_data
			// 
			this.label_data.AutoSize = true;
			this.label_data.Location = new System.Drawing.Point(75, 34);
			this.label_data.Name = "label_data";
			this.label_data.Size = new System.Drawing.Size(38, 17);
			this.label_data.TabIndex = 0;
			this.label_data.Text = "Data";
			// 
			// textBox_InputData
			// 
			this.textBox_InputData.Location = new System.Drawing.Point(119, 34);
			this.textBox_InputData.Name = "textBox_InputData";
			this.textBox_InputData.Size = new System.Drawing.Size(316, 22);
			this.textBox_InputData.TabIndex = 1;
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(441, 34);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(83, 28);
			this.btn_add.TabIndex = 2;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// label_koleksi
			// 
			this.label_koleksi.AutoSize = true;
			this.label_koleksi.Location = new System.Drawing.Point(33, 110);
			this.label_koleksi.Name = "label_koleksi";
			this.label_koleksi.Size = new System.Drawing.Size(53, 17);
			this.label_koleksi.TabIndex = 3;
			this.label_koleksi.Text = "Koleksi";
			// 
			// label_setting
			// 
			this.label_setting.AutoSize = true;
			this.label_setting.Location = new System.Drawing.Point(445, 110);
			this.label_setting.Name = "label_setting";
			this.label_setting.Size = new System.Drawing.Size(52, 17);
			this.label_setting.TabIndex = 4;
			this.label_setting.Text = "Setting";
			this.label_setting.Click += new System.EventHandler(this.label3_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(445, 207);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Output";
			// 
			// label_output
			// 
			this.label_output.AutoSize = true;
			this.label_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_output.Location = new System.Drawing.Point(552, 270);
			this.label_output.Name = "label_output";
			this.label_output.Size = new System.Drawing.Size(0, 32);
			this.label_output.TabIndex = 6;
			// 
			// listBox_data
			// 
			this.listBox_data.FormattingEnabled = true;
			this.listBox_data.ItemHeight = 16;
			this.listBox_data.Location = new System.Drawing.Point(36, 146);
			this.listBox_data.Name = "listBox_data";
			this.listBox_data.Size = new System.Drawing.Size(247, 228);
			this.listBox_data.TabIndex = 7;
			this.listBox_data.SelectedIndexChanged += new System.EventHandler(this.listBox_data_SelectedIndexChanged);
			// 
			// checkbox_aktif
			// 
			this.checkbox_aktif.AutoSize = true;
			this.checkbox_aktif.Location = new System.Drawing.Point(503, 110);
			this.checkbox_aktif.Name = "checkbox_aktif";
			this.checkbox_aktif.Size = new System.Drawing.Size(57, 21);
			this.checkbox_aktif.TabIndex = 8;
			this.checkbox_aktif.Text = "Aktif";
			this.checkbox_aktif.UseVisualStyleBackColor = true;
			// 
			// radioButton_merah
			// 
			this.radioButton_merah.AutoSize = true;
			this.radioButton_merah.Location = new System.Drawing.Point(448, 137);
			this.radioButton_merah.Name = "radioButton_merah";
			this.radioButton_merah.Size = new System.Drawing.Size(115, 21);
			this.radioButton_merah.TabIndex = 9;
			this.radioButton_merah.TabStop = true;
			this.radioButton_merah.Text = "Warna Merah";
			this.radioButton_merah.UseVisualStyleBackColor = true;
			this.radioButton_merah.CheckedChanged += new System.EventHandler(this.radioButton_merah_CheckedChanged);
			// 
			// radioButton_biru
			// 
			this.radioButton_biru.AutoSize = true;
			this.radioButton_biru.Location = new System.Drawing.Point(448, 164);
			this.radioButton_biru.Name = "radioButton_biru";
			this.radioButton_biru.Size = new System.Drawing.Size(100, 21);
			this.radioButton_biru.TabIndex = 10;
			this.radioButton_biru.TabStop = true;
			this.radioButton_biru.Text = "Warna Biru";
			this.radioButton_biru.UseVisualStyleBackColor = true;
			this.radioButton_biru.CheckedChanged += new System.EventHandler(this.radioButton_biru_CheckedChanged);
			// 
			// btn_cleardata
			// 
			this.btn_cleardata.Location = new System.Drawing.Point(448, 402);
			this.btn_cleardata.Name = "btn_cleardata";
			this.btn_cleardata.Size = new System.Drawing.Size(264, 23);
			this.btn_cleardata.TabIndex = 11;
			this.btn_cleardata.Text = "Clear";
			this.btn_cleardata.UseVisualStyleBackColor = true;
			this.btn_cleardata.Click += new System.EventHandler(this.btn_cleardata_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_cleardata);
			this.Controls.Add(this.radioButton_biru);
			this.Controls.Add(this.radioButton_merah);
			this.Controls.Add(this.checkbox_aktif);
			this.Controls.Add(this.listBox_data);
			this.Controls.Add(this.label_output);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label_setting);
			this.Controls.Add(this.label_koleksi);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.textBox_InputData);
			this.Controls.Add(this.label_data);
			this.Name = "Form1";
			this.Text = "Form Materi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_data;
		private System.Windows.Forms.TextBox textBox_InputData;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Label label_koleksi;
		private System.Windows.Forms.Label label_setting;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_output;
		private System.Windows.Forms.ListBox listBox_data;
		private System.Windows.Forms.CheckBox checkbox_aktif;
		private System.Windows.Forms.RadioButton radioButton_merah;
		private System.Windows.Forms.RadioButton radioButton_biru;
		private System.Windows.Forms.Button btn_cleardata;
	}
}

