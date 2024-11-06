namespace Геофизика_фалй
{
    partial class projects
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
            this.registerDataSet9 = new Геофизика_фалй.registerDataSet9();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projecctBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registerDataSet11 = new Геофизика_фалй.registerDataSet11();
            this.projecctBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projecctTableAdapter = new Геофизика_фалй.registerDataSet10TableAdapters.projecctTableAdapter();
            this.projecctTableAdapter1 = new Геофизика_фалй.registerDataSet11TableAdapters.projecctTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecctBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecctBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // registerDataSet9
            // 
            this.registerDataSet9.DataSetName = "registerDataSet9";
            this.registerDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 324);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(116, 51);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "Назад";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(438, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить элемент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(819, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить элемент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projecctBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(933, 294);
            this.dataGridView1.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // заказчикDataGridViewTextBoxColumn
            // 
            this.заказчикDataGridViewTextBoxColumn.DataPropertyName = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.HeaderText = "Заказчик";
            this.заказчикDataGridViewTextBoxColumn.Name = "заказчикDataGridViewTextBoxColumn";
            // 
            // датаначалаDataGridViewTextBoxColumn
            // 
            this.датаначалаDataGridViewTextBoxColumn.DataPropertyName = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.HeaderText = "Дата_начала";
            this.датаначалаDataGridViewTextBoxColumn.Name = "датаначалаDataGridViewTextBoxColumn";
            // 
            // projecctBindingSource1
            // 
            this.projecctBindingSource1.DataMember = "projecct";
            this.projecctBindingSource1.DataSource = this.registerDataSet11;
            // 
            // registerDataSet11
            // 
            this.registerDataSet11.DataSetName = "registerDataSet11";
            this.registerDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projecctTableAdapter
            // 
            this.projecctTableAdapter.ClearBeforeFill = true;
            // 
            // projecctTableAdapter1
            // 
            this.projecctTableAdapter1.ClearBeforeFill = true;
            // 
            // projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Name = "projects";
            this.Text = "projects";
            this.Load += new System.EventHandler(this.projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecctBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecctBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private registerDataSet9 registerDataSet9;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projecctBindingSource;
        private registerDataSet10TableAdapters.projecctTableAdapter projecctTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private registerDataSet11 registerDataSet11;
        private System.Windows.Forms.BindingSource projecctBindingSource1;
        private registerDataSet11TableAdapters.projecctTableAdapter projecctTableAdapter1;
    }
}