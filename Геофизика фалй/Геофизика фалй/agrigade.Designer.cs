namespace Геофизика_фалй
{
    partial class agrigade
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
            this.agrigadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerDataSet1 = new Геофизика_фалй.registerDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.registerDataSet = new Геофизика_фалй.registerDataSet();
            this.registerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agrigadeTableAdapter = new Геофизика_фалй.registerDataSet1TableAdapters.agrigadeTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серийныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrigadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.серийныйномерDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.agrigadeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // agrigadeBindingSource
            // 
            this.agrigadeBindingSource.DataMember = "agrigade";
            this.agrigadeBindingSource.DataSource = this.registerDataSet1;
            // 
            // registerDataSet1
            // 
            this.registerDataSet1.DataSetName = "registerDataSet1";
            this.registerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerDataSet
            // 
            this.registerDataSet.DataSetName = "registerDataSet";
            this.registerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerDataSetBindingSource
            // 
            this.registerDataSetBindingSource.DataSource = this.registerDataSet;
            this.registerDataSetBindingSource.Position = 0;
            // 
            // agrigadeTableAdapter
            // 
            this.agrigadeTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Добавить оборудование";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            this.модельDataGridViewTextBoxColumn.Width = 200;
            // 
            // серийныйномерDataGridViewTextBoxColumn
            // 
            this.серийныйномерDataGridViewTextBoxColumn.DataPropertyName = "серийный_номер";
            this.серийныйномерDataGridViewTextBoxColumn.HeaderText = "серийный_номер";
            this.серийныйномерDataGridViewTextBoxColumn.Name = "серийныйномерDataGridViewTextBoxColumn";
            this.серийныйномерDataGridViewTextBoxColumn.Width = 200;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить элемент ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // agrigade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "agrigade";
            this.Text = "agrigade";
            this.Load += new System.EventHandler(this.agrigade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrigadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource registerDataSetBindingSource;
        private registerDataSet registerDataSet;
        private System.Windows.Forms.Button button1;
        private registerDataSet1 registerDataSet1;
        private System.Windows.Forms.BindingSource agrigadeBindingSource;
        private registerDataSet1TableAdapters.agrigadeTableAdapter agrigadeTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серийныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}