namespace Veresiye.UI
{
	partial class FrmActivityAdd
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
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.btnQuit = new System.Windows.Forms.Button();
			this.cmbActivityType = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(121, 135);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Kaydet";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(60, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "İşlem Adı :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tutar :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(49, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "İşlem Tarihi :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "İşlem Türü :";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(121, 28);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(200, 20);
			this.txtName.TabIndex = 6;
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(121, 54);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(200, 20);
			this.txtAmount.TabIndex = 7;
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(121, 81);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 8;
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(245, 134);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 10;
			this.btnQuit.Text = "Kapat";
			this.btnQuit.UseVisualStyleBackColor = true;
			// 
			// cmbActivityType
			// 
			this.cmbActivityType.FormattingEnabled = true;
			this.cmbActivityType.Items.AddRange(new object[] {
            "Borç",
            "Ödeme",
            "Alacak",
            "Tahsilat"});
			this.cmbActivityType.Location = new System.Drawing.Point(121, 108);
			this.cmbActivityType.Name = "cmbActivityType";
			this.cmbActivityType.Size = new System.Drawing.Size(200, 21);
			this.cmbActivityType.TabIndex = 9;
			// 
			// FrmActivityAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 203);
			this.Controls.Add(this.btnQuit);
			this.Controls.Add(this.cmbActivityType);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdd);
			this.Name = "FrmActivityAdd";
			this.Text = "FrmActivityAdd";
			this.Load += new System.EventHandler(this.FrmActivityAdd_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.ComboBox cmbActivityType;
	}
}