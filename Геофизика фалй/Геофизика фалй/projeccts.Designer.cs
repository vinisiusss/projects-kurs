namespace Геофизика_фалй
{
    partial class projeccts
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
            this.registerDataSet1 = new Геофизика_фалй.registerDataSet();
            this.registerDataSet12 = new Геофизика_фалй.registerDataSet12();
            this.projecctBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projecctTableAdapter = new Геофизика_фалй.registerDataSet12TableAdapters.projecctTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.заказчикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаначалаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.площадьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.координатыТочекИзломаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.глубинаИзмеренияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПикетовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idАппаратурыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idОператораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecctBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameprojectDataGridViewTextBoxColumn,
            this.заказчикDataGridViewTextBoxColumn,
            this.датаначалаDataGridViewTextBoxColumn,
            this.площадьDataGridViewTextBoxColumn,
            this.координатыТочекИзломаDataGridViewTextBoxColumn,
            this.глубинаИзмеренияDataGridViewTextBoxColumn,
            this.количествоПикетовDataGridViewTextBoxColumn,
            this.idАппаратурыDataGridViewTextBoxColumn,
            this.idОператораDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projecctBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(917, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // registerDataSet1
            // 
            this.registerDataSet1.DataSetName = "registerDataSet";
            this.registerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registerDataSet12
            // 
            this.registerDataSet12.DataSetName = "registerDataSet12";
            this.registerDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projecctBindingSource
            // 
            this.projecctBindingSource.DataMember = "projecct";
            this.projecctBindingSource.DataSource = this.registerDataSet12;
            // 
            // projecctTableAdapter
            // 
            this.projecctTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameprojectDataGridViewTextBoxColumn
            // 
            this.nameprojectDataGridViewTextBoxColumn.DataPropertyName = "name_project";
            this.nameprojectDataGridViewTextBoxColumn.HeaderText = "name_project";
            this.nameprojectDataGridViewTextBoxColumn.Name = "nameprojectDataGridViewTextBoxColumn";
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
            // площадьDataGridViewTextBoxColumn
            // 
            this.площадьDataGridViewTextBoxColumn.DataPropertyName = "Площадь";
            this.площадьDataGridViewTextBoxColumn.HeaderText = "Площадь";
            this.площадьDataGridViewTextBoxColumn.Name = "площадьDataGridViewTextBoxColumn";
            // 
            // координатыТочекИзломаDataGridViewTextBoxColumn
            // 
            this.координатыТочекИзломаDataGridViewTextBoxColumn.DataPropertyName = "КоординатыТочекИзлома";
            this.координатыТочекИзломаDataGridViewTextBoxColumn.HeaderText = "КоординатыТочекИзлома";
            this.координатыТочекИзломаDataGridViewTextBoxColumn.Name = "координатыТочекИзломаDataGridViewTextBoxColumn";
            // 
            // глубинаИзмеренияDataGridViewTextBoxColumn
            // 
            this.глубинаИзмеренияDataGridViewTextBoxColumn.DataPropertyName = "ГлубинаИзмерения";
            this.глубинаИзмеренияDataGridViewTextBoxColumn.HeaderText = "ГлубинаИзмерения";
            this.глубинаИзмеренияDataGridViewTextBoxColumn.Name = "глубинаИзмеренияDataGridViewTextBoxColumn";
            // 
            // количествоПикетовDataGridViewTextBoxColumn
            // 
            this.количествоПикетовDataGridViewTextBoxColumn.DataPropertyName = "КоличествоПикетов";
            this.количествоПикетовDataGridViewTextBoxColumn.HeaderText = "КоличествоПикетов";
            this.количествоПикетовDataGridViewTextBoxColumn.Name = "количествоПикетовDataGridViewTextBoxColumn";
            // 
            // idАппаратурыDataGridViewTextBoxColumn
            // 
            this.idАппаратурыDataGridViewTextBoxColumn.DataPropertyName = "id_Аппаратуры";
            this.idАппаратурыDataGridViewTextBoxColumn.HeaderText = "id_Аппаратуры";
            this.idАппаратурыDataGridViewTextBoxColumn.Name = "idАппаратурыDataGridViewTextBoxColumn";
            // 
            // idОператораDataGridViewTextBoxColumn
            // 
            this.idОператораDataGridViewTextBoxColumn.DataPropertyName = "id_Оператора";
            this.idОператораDataGridViewTextBoxColumn.HeaderText = "id_Оператора";
            this.idОператораDataGridViewTextBoxColumn.Name = "idОператораDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(812, 387);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 51);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавить элемент";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 51);
            this.button2.TabIndex = 5;
            this.button2.Text = "Удалить элемент";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(5, 387);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(116, 51);
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Назад";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // projeccts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "projeccts";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.projeccts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registerDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projecctBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private registerDataSet registerDataSet1;
        private registerDataSet12 registerDataSet12;
        private System.Windows.Forms.BindingSource projecctBindingSource;
        private registerDataSet12TableAdapters.projecctTableAdapter projecctTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn заказчикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаначалаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn площадьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn координатыТочекИзломаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn глубинаИзмеренияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПикетовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idАппаратурыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idОператораDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Button1;
    }
}