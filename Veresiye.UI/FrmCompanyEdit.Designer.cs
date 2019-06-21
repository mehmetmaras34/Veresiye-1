namespace Veresiye.UI
{
	partial class FrmCompanyEdit
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
			this.txtRegion = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDeleteActivity = new System.Windows.Forms.Button();
			this.btnEditActivity = new System.Windows.Forms.Button();
			this.btnAddActivity = new System.Windows.Forms.Button();
			this.dgvActivity = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).BeginInit();
			this.SuspendLayout();
			// 
			// btnQuit
			// 
			this.btnQuit.Location = new System.Drawing.Point(524, 54);
			this.btnQuit.Name = "btnQuit";
			this.btnQuit.Size = new System.Drawing.Size(75, 23);
			this.btnQuit.TabIndex = 19;
			this.btnQuit.Text = "Kapat";
			this.btnQuit.UseVisualStyleBackColor = true;
			this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
			// 
			// txtRegion
			// 
			this.txtRegion.Location = new System.Drawing.Point(335, 54);
			this.txtRegion.Name = "txtRegion";
			this.txtRegion.Size = new System.Drawing.Size(163, 20);
			this.txtRegion.TabIndex = 18;
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(335, 28);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(163, 20);
			this.txtCity.TabIndex = 17;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(108, 54);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(163, 20);
			this.txtPhone.TabIndex = 16;
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Location = new System.Drawing.Point(108, 28);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(163, 20);
			this.txtCompanyName.TabIndex = 15;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(524, 26);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "Kaydet";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(289, 54);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 13;
			this.label4.Text = "Bölge :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(292, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 12;
			this.label3.Text = "Şehir :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(53, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Telefon :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Firma Adı :";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDeleteActivity);
			this.panel1.Controls.Add(this.btnEditActivity);
			this.panel1.Controls.Add(this.btnAddActivity);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnQuit);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtRegion);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtCity);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.txtPhone);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.txtCompanyName);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(669, 132);
			this.panel1.TabIndex = 20;
			// 
			// btnDeleteActivity
			// 
			this.btnDeleteActivity.Location = new System.Drawing.Point(345, 95);
			this.btnDeleteActivity.Name = "btnDeleteActivity";
			this.btnDeleteActivity.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteActivity.TabIndex = 22;
			this.btnDeleteActivity.Text = "Sil";
			this.btnDeleteActivity.UseVisualStyleBackColor = true;
			this.btnDeleteActivity.Click += new System.EventHandler(this.BtnDeleteActivity_Click);
			// 
			// btnEditActivity
			// 
			this.btnEditActivity.Location = new System.Drawing.Point(195, 95);
			this.btnEditActivity.Name = "btnEditActivity";
			this.btnEditActivity.Size = new System.Drawing.Size(75, 23);
			this.btnEditActivity.TabIndex = 21;
			this.btnEditActivity.Text = "Düzenle";
			this.btnEditActivity.UseVisualStyleBackColor = true;
			this.btnEditActivity.Click += new System.EventHandler(this.BtnEditActivity_Click);
			// 
			// btnAddActivity
			// 
			this.btnAddActivity.Location = new System.Drawing.Point(49, 96);
			this.btnAddActivity.Name = "btnAddActivity";
			this.btnAddActivity.Size = new System.Drawing.Size(75, 23);
			this.btnAddActivity.TabIndex = 20;
			this.btnAddActivity.Text = "Yeni İşlem";
			this.btnAddActivity.UseVisualStyleBackColor = true;
			this.btnAddActivity.Click += new System.EventHandler(this.BtnAddActivity_Click);
			// 
			// dgvActivity
			// 
			this.dgvActivity.AllowUserToAddRows = false;
			this.dgvActivity.AllowUserToDeleteRows = false;
			this.dgvActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvActivity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dgvActivity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvActivity.Location = new System.Drawing.Point(0, 132);
			this.dgvActivity.Name = "dgvActivity";
			this.dgvActivity.ReadOnly = true;
			this.dgvActivity.Size = new System.Drawing.Size(669, 239);
			this.dgvActivity.TabIndex = 21;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "Id";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "Name";
			this.Column2.HeaderText = "İşlem Adı";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Amount";
			this.Column3.HeaderText = "Tutar";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "TransactionDate";
			this.Column4.HeaderText = "İşlem Tarihi";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "ActivityType";
			this.Column5.HeaderText = "İşlem Türü";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// FrmCompanyEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 371);
			this.Controls.Add(this.dgvActivity);
			this.Controls.Add(this.panel1);
			this.Name = "FrmCompanyEdit";
			this.Text = "FrmCompanyEdit";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCompanyEdit_FormClosing);
			this.Load += new System.EventHandler(this.FrmCompanyEdit_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvActivity)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnQuit;
		private System.Windows.Forms.TextBox txtRegion;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDeleteActivity;
		private System.Windows.Forms.Button btnEditActivity;
		private System.Windows.Forms.Button btnAddActivity;
		private System.Windows.Forms.DataGridView dgvActivity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}