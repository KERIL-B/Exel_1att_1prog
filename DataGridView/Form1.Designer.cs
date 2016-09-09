namespace DataGridViewProject
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfColumnsTB = new System.Windows.Forms.TextBox();
            this.createTableB = new System.Windows.Forms.Button();
            this.refreshB = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteRowNumberTB = new System.Windows.Forms.TextBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteBySelect = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.addTableDGV = new System.Windows.Forms.DataGridView();
            this.addB = new System.Windows.Forms.Button();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableDGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.changeInputTB = new System.Windows.Forms.TextBox();
            this.changeB = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.colourB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.defaultColorB = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTableDGV)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDGV)).BeginInit();
            this.flowLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.numberOfColumnsTB);
            this.flowLayoutPanel1.Controls.Add(this.createTableB);
            this.flowLayoutPanel1.Controls.Add(this.refreshB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 126);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter number of columns:";
            // 
            // numberOfColumnsTB
            // 
            this.numberOfColumnsTB.Location = new System.Drawing.Point(3, 29);
            this.numberOfColumnsTB.Name = "numberOfColumnsTB";
            this.numberOfColumnsTB.Size = new System.Drawing.Size(153, 20);
            this.numberOfColumnsTB.TabIndex = 1;
            // 
            // createTableB
            // 
            this.createTableB.Location = new System.Drawing.Point(3, 55);
            this.createTableB.Name = "createTableB";
            this.createTableB.Size = new System.Drawing.Size(153, 23);
            this.createTableB.TabIndex = 2;
            this.createTableB.Text = "Create table";
            this.createTableB.UseVisualStyleBackColor = true;
            this.createTableB.Click += new System.EventHandler(this.createTableB_Click);
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(3, 84);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(153, 23);
            this.refreshB.TabIndex = 3;
            this.refreshB.Text = "Refresh/Clear";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.deleteRowNumberTB);
            this.flowLayoutPanel2.Controls.Add(this.deleteB);
            this.flowLayoutPanel2.Controls.Add(this.deleteBySelect);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 115);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(156, 138);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of row you want to delet";
            // 
            // deleteRowNumberTB
            // 
            this.deleteRowNumberTB.Location = new System.Drawing.Point(3, 42);
            this.deleteRowNumberTB.Name = "deleteRowNumberTB";
            this.deleteRowNumberTB.Size = new System.Drawing.Size(153, 20);
            this.deleteRowNumberTB.TabIndex = 1;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(3, 68);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(153, 23);
            this.deleteB.TabIndex = 4;
            this.deleteB.Text = "Delete";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.changeInputTB);
            this.flowLayoutPanel3.Controls.Add(this.changeB);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 241);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(156, 109);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // deleteBySelect
            // 
            this.deleteBySelect.Location = new System.Drawing.Point(3, 97);
            this.deleteBySelect.Name = "deleteBySelect";
            this.deleteBySelect.Size = new System.Drawing.Size(153, 23);
            this.deleteBySelect.TabIndex = 5;
            this.deleteBySelect.Text = "Delete by select";
            this.deleteBySelect.UseVisualStyleBackColor = true;
            this.deleteBySelect.Click += new System.EventHandler(this.deleteBySelect_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.addTableDGV);
            this.flowLayoutPanel4.Controls.Add(this.addB);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(163, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(525, 98);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add row";
            // 
            // addTableDGV
            // 
            this.addTableDGV.AllowUserToAddRows = false;
            this.addTableDGV.AllowUserToOrderColumns = true;
            this.addTableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addTableDGV.Location = new System.Drawing.Point(3, 16);
            this.addTableDGV.Name = "addTableDGV";
            this.addTableDGV.Size = new System.Drawing.Size(522, 49);
            this.addTableDGV.StandardTab = true;
            this.addTableDGV.TabIndex = 1;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(3, 71);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(522, 23);
            this.addB.TabIndex = 4;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.tableDGV);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(163, 106);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(525, 319);
            this.flowLayoutPanel5.TabIndex = 4;
            // 
            // tableDGV
            // 
            this.tableDGV.AllowUserToAddRows = false;
            this.tableDGV.AllowUserToDeleteRows = false;
            this.tableDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDGV.Location = new System.Drawing.Point(3, 3);
            this.tableDGV.Name = "tableDGV";
            this.tableDGV.ReadOnly = true;
            this.tableDGV.Size = new System.Drawing.Size(522, 309);
            this.tableDGV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CREATE TABLE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DELETE ROW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CHANGE INPUT DATA";
            // 
            // changeInputTB
            // 
            this.changeInputTB.Location = new System.Drawing.Point(3, 42);
            this.changeInputTB.Name = "changeInputTB";
            this.changeInputTB.Size = new System.Drawing.Size(153, 20);
            this.changeInputTB.TabIndex = 2;
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(3, 68);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(153, 23);
            this.changeB.TabIndex = 5;
            this.changeB.Text = "Change";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "Select cell and enter new input";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label7);
            this.flowLayoutPanel6.Controls.Add(this.label9);
            this.flowLayoutPanel6.Controls.Add(this.colourB);
            this.flowLayoutPanel6.Controls.Add(this.defaultColorB);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(4, 337);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(156, 88);
            this.flowLayoutPanel6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "PAINT CELL                   ";
            // 
            // colourB
            // 
            this.colourB.Location = new System.Drawing.Point(3, 29);
            this.colourB.Name = "colourB";
            this.colourB.Size = new System.Drawing.Size(153, 23);
            this.colourB.TabIndex = 6;
            this.colourB.Text = "Paint";
            this.colourB.UseVisualStyleBackColor = true;
            this.colourB.Click += new System.EventHandler(this.colourB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Select cell";
            // 
            // defaultColorB
            // 
            this.defaultColorB.Location = new System.Drawing.Point(3, 58);
            this.defaultColorB.Name = "defaultColorB";
            this.defaultColorB.Size = new System.Drawing.Size(153, 23);
            this.defaultColorB.TabIndex = 8;
            this.defaultColorB.Text = "Reset to default";
            this.defaultColorB.UseVisualStyleBackColor = true;
            this.defaultColorB.Click += new System.EventHandler(this.defaultColorB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 428);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Exel_2.0";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTableDGV)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableDGV)).EndInit();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfColumnsTB;
        private System.Windows.Forms.Button createTableB;
        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deleteRowNumberTB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button deleteBySelect;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView addTableDGV;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.DataGridView tableDGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox changeInputTB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button colourB;
        private System.Windows.Forms.Button defaultColorB;
    }
}

