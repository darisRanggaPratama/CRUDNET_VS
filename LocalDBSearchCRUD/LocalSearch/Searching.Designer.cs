namespace LocalSearch
{
	partial class Browse
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browse));
			this.lbl_name = new System.Windows.Forms.Label();
			this.lbl_address = new System.Windows.Forms.Label();
			this.lbl_surename = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.mytableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet = new LocalSearch.DataSet();
			this.txt_surename = new System.Windows.Forms.TextBox();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.txt_search = new System.Windows.Forms.TextBox();
			this.btn_insert = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.surenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_update = new System.Windows.Forms.Button();
			this.btn_search = new System.Windows.Forms.Button();
			this.btn_display = new System.Windows.Forms.Button();
			this.mytableTableAdapter = new LocalSearch.DataSetTableAdapters.mytableTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.mytableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_name
			// 
			this.lbl_name.AutoSize = true;
			this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_name.Location = new System.Drawing.Point(16, 16);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(48, 16);
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "Name";
			// 
			// lbl_address
			// 
			this.lbl_address.AutoSize = true;
			this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_address.Location = new System.Drawing.Point(16, 80);
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.Size = new System.Drawing.Size(65, 16);
			this.lbl_address.TabIndex = 0;
			this.lbl_address.Text = "Address";
			// 
			// lbl_surename
			// 
			this.lbl_surename.AutoSize = true;
			this.lbl_surename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_surename.Location = new System.Drawing.Point(16, 48);
			this.lbl_surename.Name = "lbl_surename";
			this.lbl_surename.Size = new System.Drawing.Size(77, 16);
			this.lbl_surename.TabIndex = 0;
			this.lbl_surename.Text = "Surename";
			// 
			// txt_name
			// 
			this.txt_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mytableBindingSource, "Name", true));
			this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_name.Location = new System.Drawing.Point(96, 16);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(208, 22);
			this.txt_name.TabIndex = 0;
			// 
			// mytableBindingSource
			// 
			this.mytableBindingSource.DataMember = "mytable";
			this.mytableBindingSource.DataSource = this.dataSet;
			// 
			// dataSet
			// 
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// txt_surename
			// 
			this.txt_surename.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mytableBindingSource, "Surename", true));
			this.txt_surename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_surename.Location = new System.Drawing.Point(96, 48);
			this.txt_surename.Name = "txt_surename";
			this.txt_surename.Size = new System.Drawing.Size(208, 22);
			this.txt_surename.TabIndex = 1;
			// 
			// txt_address
			// 
			this.txt_address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mytableBindingSource, "Address", true));
			this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_address.Location = new System.Drawing.Point(96, 80);
			this.txt_address.Multiline = true;
			this.txt_address.Name = "txt_address";
			this.txt_address.Size = new System.Drawing.Size(296, 56);
			this.txt_address.TabIndex = 2;
			// 
			// txt_search
			// 
			this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_search.Location = new System.Drawing.Point(96, 176);
			this.txt_search.Name = "txt_search";
			this.txt_search.Size = new System.Drawing.Size(208, 22);
			this.txt_search.TabIndex = 6;
			// 
			// btn_insert
			// 
			this.btn_insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_insert.Location = new System.Drawing.Point(96, 144);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(75, 23);
			this.btn_insert.TabIndex = 3;
			this.btn_insert.Text = "Insert";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surenameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.mytableBindingSource;
			this.dataGridView.Location = new System.Drawing.Point(16, 208);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(376, 216);
			this.dataGridView.TabIndex = 8;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// surenameDataGridViewTextBoxColumn
			// 
			this.surenameDataGridViewTextBoxColumn.DataPropertyName = "Surename";
			this.surenameDataGridViewTextBoxColumn.HeaderText = "Surename";
			this.surenameDataGridViewTextBoxColumn.Name = "surenameDataGridViewTextBoxColumn";
			// 
			// addressDataGridViewTextBoxColumn
			// 
			this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
			this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
			this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 176);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(72, 26);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_delete.Location = new System.Drawing.Point(184, 144);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 4;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_update
			// 
			this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_update.Location = new System.Drawing.Point(272, 144);
			this.btn_update.Name = "btn_update";
			this.btn_update.Size = new System.Drawing.Size(75, 23);
			this.btn_update.TabIndex = 5;
			this.btn_update.Text = "Update";
			this.btn_update.UseVisualStyleBackColor = true;
			this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
			// 
			// btn_search
			// 
			this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_search.Location = new System.Drawing.Point(320, 176);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(75, 23);
			this.btn_search.TabIndex = 7;
			this.btn_search.Text = "Search";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// btn_display
			// 
			this.btn_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_display.Location = new System.Drawing.Point(168, 432);
			this.btn_display.Name = "btn_display";
			this.btn_display.Size = new System.Drawing.Size(75, 23);
			this.btn_display.TabIndex = 9;
			this.btn_display.Text = "Display";
			this.btn_display.UseVisualStyleBackColor = true;
			this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
			// 
			// mytableTableAdapter
			// 
			this.mytableTableAdapter.ClearBeforeFill = true;
			// 
			// Browse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 460);
			this.Controls.Add(this.btn_display);
			this.Controls.Add(this.btn_search);
			this.Controls.Add(this.btn_update);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.txt_search);
			this.Controls.Add(this.txt_address);
			this.Controls.Add(this.txt_surename);
			this.Controls.Add(this.txt_name);
			this.Controls.Add(this.lbl_surename);
			this.Controls.Add(this.lbl_address);
			this.Controls.Add(this.lbl_name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximumSize = new System.Drawing.Size(421, 503);
			this.MinimumSize = new System.Drawing.Size(421, 503);
			this.Name = "Browse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search";
			this.Load += new System.EventHandler(this.Browse_Load);
			((System.ComponentModel.ISupportInitialize)(this.mytableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Label lbl_address;
		private System.Windows.Forms.Label lbl_surename;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_surename;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.TextBox txt_search;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_update;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.Button btn_display;
		private DataSet dataSet;
		private System.Windows.Forms.BindingSource mytableBindingSource;
		private DataSetTableAdapters.mytableTableAdapter mytableTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn surenameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
	}
}

