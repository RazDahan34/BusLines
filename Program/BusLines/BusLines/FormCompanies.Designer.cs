namespace BusLines
{
    partial class FormCompanies
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compLocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compColorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCompanies = new BusLines.DataSetCompanies();
            this.tblCompaniesTableAdapter = new BusLines.DataSetCompaniesTableAdapters.tblCompaniesTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compNameDataGridViewTextBoxColumn,
            this.compAddressDataGridViewTextBoxColumn,
            this.compLocationDataGridViewTextBoxColumn,
            this.compPhoneDataGridViewTextBoxColumn,
            this.compPictureDataGridViewTextBoxColumn,
            this.compColorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCompaniesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // compNameDataGridViewTextBoxColumn
            // 
            this.compNameDataGridViewTextBoxColumn.DataPropertyName = "compName";
            this.compNameDataGridViewTextBoxColumn.HeaderText = "שם חברה";
            this.compNameDataGridViewTextBoxColumn.Name = "compNameDataGridViewTextBoxColumn";
            // 
            // compAddressDataGridViewTextBoxColumn
            // 
            this.compAddressDataGridViewTextBoxColumn.DataPropertyName = "compAddress";
            this.compAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.compAddressDataGridViewTextBoxColumn.Name = "compAddressDataGridViewTextBoxColumn";
            // 
            // compLocationDataGridViewTextBoxColumn
            // 
            this.compLocationDataGridViewTextBoxColumn.DataPropertyName = "compLocation";
            this.compLocationDataGridViewTextBoxColumn.HeaderText = "יישוב";
            this.compLocationDataGridViewTextBoxColumn.Name = "compLocationDataGridViewTextBoxColumn";
            // 
            // compPhoneDataGridViewTextBoxColumn
            // 
            this.compPhoneDataGridViewTextBoxColumn.DataPropertyName = "compPhone";
            this.compPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.compPhoneDataGridViewTextBoxColumn.Name = "compPhoneDataGridViewTextBoxColumn";
            // 
            // compPictureDataGridViewTextBoxColumn
            // 
            this.compPictureDataGridViewTextBoxColumn.DataPropertyName = "compPicture";
            this.compPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.compPictureDataGridViewTextBoxColumn.Name = "compPictureDataGridViewTextBoxColumn";
            // 
            // compColorDataGridViewTextBoxColumn
            // 
            this.compColorDataGridViewTextBoxColumn.DataPropertyName = "compColor";
            this.compColorDataGridViewTextBoxColumn.HeaderText = "צבע";
            this.compColorDataGridViewTextBoxColumn.Name = "compColorDataGridViewTextBoxColumn";
            // 
            // tblCompaniesBindingSource
            // 
            this.tblCompaniesBindingSource.DataMember = "tblCompanies";
            this.tblCompaniesBindingSource.DataSource = this.dataSetCompanies;
            // 
            // dataSetCompanies
            // 
            this.dataSetCompanies.DataSetName = "DataSetCompanies";
            this.dataSetCompanies.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCompaniesTableAdapter
            // 
            this.tblCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(331, 306);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(222, 60);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "שמור";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(369, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "טבלת חברות";
            // 
            // FormCompanies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormCompanies";
            this.Text = "FormCompanies";
            this.Load += new System.EventHandler(this.FormCompanies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetCompanies dataSetCompanies;
        private System.Windows.Forms.BindingSource tblCompaniesBindingSource;
        private DataSetCompaniesTableAdapters.tblCompaniesTableAdapter tblCompaniesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn compNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compLocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compColorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label2;
    }
}