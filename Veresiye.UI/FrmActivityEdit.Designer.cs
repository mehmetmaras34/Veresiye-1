namespace Veresiye.UI
{
	partial class FrmActivityEdit
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
			this.btnQuit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.cmbActivityType = new System.Windows.Forms.ComboBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(208, 142);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 19;
			this.btnQuit.Text = "Kapat";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(83, 142);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Kaydet";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// cmbActivityType
			// 
			this.cmbActivityType.FormattingEnabled = true;
			this.cmbActivityType.Items.AddRange(new object[] {
            "Borç",
            "Ödeme",
            "Alacak",
            "Tahsilat"});
			this.cmbActivityType.Location = new System.Drawing.Point(83, 106);
			this.cmbActivityType.Name = "cmbActivityType";
			this.cmbActivityType.Size = new System.Drawing.Size(200, 21);
			this.cmbActivityType.TabIndex = 27;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(83, 79);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 26;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(83, 52);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(200, 20);
			this.txtAmount.TabIndex = 25;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(83, 26);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(200, 20);
			this.txtName.TabIndex = 24;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 23;
			this.label4.Text = "İşlem Türü :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "İşlem Tarihi :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Tutar :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "İşlem Adı :";
			// 
			// FrmActivityEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(311, 193);
			this.Controls.Add(this.cmbActivityType);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.btnSave);
			this.Name = "FrmActivityEdit";
			this.Text = "FrmActivityEdit";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmActivityEdit_FormClosing);
			this.Load += new System.EventHandler(this.FrmActivityEdit_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cmbActivityType;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}