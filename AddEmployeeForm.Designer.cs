namespace AISTex
{
    partial class AddEmployeeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxTableSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.zap1 = new System.Windows.Forms.Button();
            this.zap2 = new System.Windows.Forms.Button();
            this.zap3 = new System.Windows.Forms.Button();
            this.zap4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(626, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выйти из системы";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 278);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboBoxTableSelector
            // 
            this.comboBoxTableSelector.FormattingEnabled = true;
            this.comboBoxTableSelector.Location = new System.Drawing.Point(626, 325);
            this.comboBoxTableSelector.Name = "comboBoxTableSelector";
            this.comboBoxTableSelector.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTableSelector.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выбор таблиц";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefresh.Location = new System.Drawing.Point(626, 377);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(161, 28);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "Обновить данные";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(11, 309);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.Size = new System.Drawing.Size(439, 130);
            this.dataGridViewResults.TabIndex = 14;
            // 
            // zap1
            // 
            this.zap1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zap1.Location = new System.Drawing.Point(456, 309);
            this.zap1.Name = "zap1";
            this.zap1.Size = new System.Drawing.Size(161, 28);
            this.zap1.TabIndex = 15;
            this.zap1.Text = "Запрос 1";
            this.zap1.UseVisualStyleBackColor = true;
            this.zap1.Click += new System.EventHandler(this.zap1_Click);
            // 
            // zap2
            // 
            this.zap2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zap2.Location = new System.Drawing.Point(456, 343);
            this.zap2.Name = "zap2";
            this.zap2.Size = new System.Drawing.Size(161, 28);
            this.zap2.TabIndex = 16;
            this.zap2.Text = "Запрос 2";
            this.zap2.UseVisualStyleBackColor = true;
            this.zap2.Click += new System.EventHandler(this.zap2_Click);
            // 
            // zap3
            // 
            this.zap3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zap3.Location = new System.Drawing.Point(456, 377);
            this.zap3.Name = "zap3";
            this.zap3.Size = new System.Drawing.Size(161, 28);
            this.zap3.TabIndex = 17;
            this.zap3.Text = "Запрос 3";
            this.zap3.UseVisualStyleBackColor = true;
            this.zap3.Click += new System.EventHandler(this.zap3_Click);
            // 
            // zap4
            // 
            this.zap4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zap4.Location = new System.Drawing.Point(456, 411);
            this.zap4.Name = "zap4";
            this.zap4.Size = new System.Drawing.Size(161, 28);
            this.zap4.TabIndex = 18;
            this.zap4.Text = "Запрос 4";
            this.zap4.UseVisualStyleBackColor = true;
            this.zap4.Click += new System.EventHandler(this.zap4_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.zap4);
            this.Controls.Add(this.zap3);
            this.Controls.Add(this.zap2);
            this.Controls.Add(this.zap1);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTableSelector);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxTableSelector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Button zap1;
        private System.Windows.Forms.Button zap2;
        private System.Windows.Forms.Button zap3;
        private System.Windows.Forms.Button zap4;
    }
}

