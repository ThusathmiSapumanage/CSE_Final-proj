namespace HR
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPDataSet1 = new HR.FPDataSet1();
            this.fPDataSet = new HR.FPDataSet();
            this.fPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new HR.FPDataSet1TableAdapters.employeeTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.leaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPDataSet2 = new HR.FPDataSet2();
            this.leaveTableAdapter = new HR.FPDataSet2TableAdapters.leaveTableAdapter();
            this.promotionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fPDataSet3 = new HR.FPDataSet3();
            this.promotionTableAdapter = new HR.FPDataSet3TableAdapters.PromotionTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pronowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fprojectDataSet2 = new HR.FprojectDataSet2();
            this.fprojectDataSet = new HR.FprojectDataSet();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new HR.FprojectDataSetTableAdapters.employeeTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgivenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fprojectDataSet1 = new HR.FprojectDataSet1();
            this.leaveTableAdapter1 = new HR.FprojectDataSet1TableAdapters.leaveTableAdapter();
            this.employeeTableAdapter2 = new HR.FprojectDataSet2TableAdapters.employeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fprojectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fprojectDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(417, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Employee Data";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.fPDataSet1;
            // 
            // fPDataSet1
            // 
            this.fPDataSet1.DataSetName = "FPDataSet1";
            this.fPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fPDataSet
            // 
            this.fPDataSet.DataSetName = "FPDataSet";
            this.fPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fPDataSetBindingSource
            // 
            this.fPDataSetBindingSource.DataSource = this.fPDataSet;
            this.fPDataSetBindingSource.Position = 0;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(445, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "View Employee Leave Data";
            // 
            // leaveBindingSource
            // 
            this.leaveBindingSource.DataMember = "leave";
            this.leaveBindingSource.DataSource = this.fPDataSet2;
            // 
            // fPDataSet2
            // 
            this.fPDataSet2.DataSetName = "FPDataSet2";
            this.fPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveTableAdapter
            // 
            this.leaveTableAdapter.ClearBeforeFill = true;
            // 
            // promotionBindingSource
            // 
            this.promotionBindingSource.DataMember = "Promotion";
            this.promotionBindingSource.DataSource = this.fPDataSet3;
            // 
            // fPDataSet3
            // 
            this.fPDataSet3.DataSetName = "FPDataSet3";
            this.fPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // promotionTableAdapter
            // 
            this.promotionTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1034, 720);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pronowDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.batchDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(144, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 227);
            this.dataGridView1.TabIndex = 7;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "e_id";
            this.eidDataGridViewTextBoxColumn.HeaderText = "e_id";
            this.eidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            this.eidDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pronowDataGridViewTextBoxColumn
            // 
            this.pronowDataGridViewTextBoxColumn.DataPropertyName = "pro_now";
            this.pronowDataGridViewTextBoxColumn.HeaderText = "pro_now";
            this.pronowDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pronowDataGridViewTextBoxColumn.Name = "pronowDataGridViewTextBoxColumn";
            this.pronowDataGridViewTextBoxColumn.Width = 125;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 125;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 125;
            // 
            // batchDataGridViewTextBoxColumn
            // 
            this.batchDataGridViewTextBoxColumn.DataPropertyName = "batch";
            this.batchDataGridViewTextBoxColumn.HeaderText = "batch";
            this.batchDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.batchDataGridViewTextBoxColumn.Name = "batchDataGridViewTextBoxColumn";
            this.batchDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeBindingSource2
            // 
            this.employeeBindingSource2.DataMember = "employee";
            this.employeeBindingSource2.DataSource = this.fprojectDataSet2;
            // 
            // fprojectDataSet2
            // 
            this.fprojectDataSet2.DataSetName = "FprojectDataSet2";
            this.fprojectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fprojectDataSet
            // 
            this.fprojectDataSet.DataSetName = "FprojectDataSet";
            this.fprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "employee";
            this.employeeBindingSource1.DataSource = this.fprojectDataSet;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lidDataGridViewTextBoxColumn,
            this.dtakenDataGridViewTextBoxColumn,
            this.dgivenDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.eidDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.leaveBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(144, 440);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(975, 239);
            this.dataGridView2.TabIndex = 8;
            // 
            // lidDataGridViewTextBoxColumn
            // 
            this.lidDataGridViewTextBoxColumn.DataPropertyName = "l_id";
            this.lidDataGridViewTextBoxColumn.HeaderText = "l_id";
            this.lidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lidDataGridViewTextBoxColumn.Name = "lidDataGridViewTextBoxColumn";
            this.lidDataGridViewTextBoxColumn.Width = 125;
            // 
            // dtakenDataGridViewTextBoxColumn
            // 
            this.dtakenDataGridViewTextBoxColumn.DataPropertyName = "d_taken";
            this.dtakenDataGridViewTextBoxColumn.HeaderText = "d_taken";
            this.dtakenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dtakenDataGridViewTextBoxColumn.Name = "dtakenDataGridViewTextBoxColumn";
            this.dtakenDataGridViewTextBoxColumn.Width = 125;
            // 
            // dgivenDataGridViewTextBoxColumn
            // 
            this.dgivenDataGridViewTextBoxColumn.DataPropertyName = "d_given";
            this.dgivenDataGridViewTextBoxColumn.HeaderText = "d_given";
            this.dgivenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dgivenDataGridViewTextBoxColumn.Name = "dgivenDataGridViewTextBoxColumn";
            this.dgivenDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // eidDataGridViewTextBoxColumn1
            // 
            this.eidDataGridViewTextBoxColumn1.DataPropertyName = "e_id";
            this.eidDataGridViewTextBoxColumn1.HeaderText = "e_id";
            this.eidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.eidDataGridViewTextBoxColumn1.Name = "eidDataGridViewTextBoxColumn1";
            this.eidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // leaveBindingSource1
            // 
            this.leaveBindingSource1.DataMember = "leave";
            this.leaveBindingSource1.DataSource = this.fprojectDataSet1;
            // 
            // fprojectDataSet1
            // 
            this.fprojectDataSet1.DataSetName = "FprojectDataSet1";
            this.fprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveTableAdapter1
            // 
            this.leaveTableAdapter1.ClearBeforeFill = true;
            // 
            // employeeTableAdapter2
            // 
            this.employeeTableAdapter2.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1195, 804);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.promotionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fPDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fprojectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fprojectDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fPDataSetBindingSource;
        private FPDataSet fPDataSet;
        private FPDataSet1 fPDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private FPDataSet1TableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Label label2;
        private FPDataSet2 fPDataSet2;
        private System.Windows.Forms.BindingSource leaveBindingSource;
        private FPDataSet2TableAdapters.leaveTableAdapter leaveTableAdapter;
        private FPDataSet3 fPDataSet3;
        private System.Windows.Forms.BindingSource promotionBindingSource;
        private FPDataSet3TableAdapters.PromotionTableAdapter promotionTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FprojectDataSet fprojectDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private FprojectDataSetTableAdapters.employeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pronowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FprojectDataSet1 fprojectDataSet1;
        private System.Windows.Forms.BindingSource leaveBindingSource1;
        private FprojectDataSet1TableAdapters.leaveTableAdapter leaveTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgivenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn1;
        private FprojectDataSet2 fprojectDataSet2;
        private System.Windows.Forms.BindingSource employeeBindingSource2;
        private FprojectDataSet2TableAdapters.employeeTableAdapter employeeTableAdapter2;
    }
}