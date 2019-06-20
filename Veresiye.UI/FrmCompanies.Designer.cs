namespace Veresiye.UI
{
	partial class FrmCompanies
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
			this.dgvCompanies = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCompanies
			// 
			this.dgvCompanies.AllowUserToAddRows = false;
			this.dgvCompanies.AllowUserToDeleteRows = false;
			this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1});
			this.dgvCompanies.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCompanies.Location = new System.Drawing.Point(0, 0);
			this.dgvCompanies.Name = "dgvCompanies";
			this.dgvCompanies.ReadOnly = true;
			this.dgvCompanies.Size = new System.Drawing.Size(730, 372);
			this.dgvCompanies.TabIndex = 0;
			// 
			// ID
			// 
			this.ID.DataPropertyName = "Id";
			this.ID.HeaderText = "Id";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Name";
			this.Column1.HeaderText = "Firma Adı";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnEdit);
			this.panel1.Controls.Add(this.btnAdd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(730, 45);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(437, 13);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Firma Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(261, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(96, 23);
			this.btnEdit.TabIndex = 1;
			this.btnEdit.Text = "Firma Düzenle";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(90, 13);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Firma Ekle";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// FrmCompanies
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(730, 372);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvCompanies);
			this.Name = "FrmCompanies";
			this.Text = "FrmCompanies";
			this.Load += new System.EventHandler(this.FrmCompanies_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvCompanies;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
	}
}