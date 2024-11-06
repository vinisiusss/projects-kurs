namespace Геофизика_фалй
{
    partial class @operator
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фиоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактныйномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registerDataSet8 = new Геофизика_фалй.registerDataSet8();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.registerDataSet7 = new Геофизика_фалй.registerDataSet7();
            this.agrigadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agrigadeTableAdapter = new Геофизика_фалй.registerDataSet7TableAdapters.agrigadeTableAdapter();
            this.operatorTableAdapter = new Геофизика_фалй.registerDataSet8TableAdapters.operatorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrigadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.фиоDataGridViewTextBoxColumn,
            this.контактныйномерDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.возрастDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operatorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 200);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // фиоDataGridViewTextBoxColumn
            // 
            this.фиоDataGridViewTextBoxColumn.DataPropertyName = "Фио";
            this.фиоDataGridViewTextBoxColumn.HeaderText = "Фио";
            this.фиоDataGridViewTextBoxColumn.Name = "фиоDataGridViewTextBoxColumn";
            // 
            // контактныйномерDataGridViewTextBoxColumn
            // 
            this.контактныйномерDataGridViewTextBoxColumn.DataPropertyName = "контактный_номер";
            this.контактныйномерDataGridViewTextBoxColumn.HeaderText = "контактный_номер";
            this.контактныйномерDataGridViewTextBoxColumn.Name = "контактныйномерDataGridViewTextBoxColumn";
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            // 
            // возрастDataGridViewTextBoxColumn
            // 
            this.возрастDataGridViewTextBoxColumn.DataPropertyName = "Возраст";
            this.возрастDataGridViewTextBoxColumn.HeaderText = "Возраст";
            this.возрастDataGridViewTextBoxColumn.Name = "возрастDataGridViewTextBoxColumn";
            // 
            // operatorBindingSource
            // 
            this.operatorBindingSource.DataMember = "operator";
            this.operatorBindingSource.DataSource = this.registerDataSet8;
            // 
            // registerDataSet8
            // 
            this.registerDataSet8.DataSetName = "registerDataSet8";
            this.registerDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(238, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить оператора";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 246);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить оператора";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // registerDataSet7
            // 
            this.registerDataSet7.DataSetName = "registerDataSet7";
            this.registerDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agrigadeBindingSource
            // 
            this.agrigadeBindingSource.DataMember = "agrigade";
            this.agrigadeBindingSource.DataSource = this.registerDataSet7;
            // 
            // agrigadeTableAdapter
            // 
            this.agrigadeTableAdapter.ClearBeforeFill = true;
            // 
            // operatorTableAdapter
            // 
            this.operatorTableAdapter.ClearBeforeFill = true;
            // 
            // @operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 352);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "@operator";
            this.Text = "@operator";
            this.Load += new System.EventHandler(this.operator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agrigadeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private registerDataSet7 registerDataSet7;
        private System.Windows.Forms.BindingSource agrigadeBindingSource;
        private registerDataSet7TableAdapters.agrigadeTableAdapter agrigadeTableAdapter;
        private registerDataSet8 registerDataSet8;
        private System.Windows.Forms.BindingSource operatorBindingSource;
        private registerDataSet8TableAdapters.operatorTableAdapter operatorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фиоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактныйномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастDataGridViewTextBoxColumn;
    }
}