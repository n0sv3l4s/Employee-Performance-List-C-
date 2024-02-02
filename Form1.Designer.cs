namespace WindowsFormsApp4
{
    partial class Form1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnBestRating = new System.Windows.Forms.Button();
            this.btnWorstRating = new System.Windows.Forms.Button();
            this.btnSortByRating = new System.Windows.Forms.Button();
            this.btnAverageRating = new System.Windows.Forms.Button();
            this.btnAboveAverage = new System.Windows.Forms.Button();
            this.btnBelowAverage = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(31, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(158, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(218, 68);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(157, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(429, 68);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(57, 20);
            this.txtRating.TabIndex = 2;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(551, 66);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(110, 23);
            this.btnAddEmployee.TabIndex = 3;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnBestRating
            // 
            this.btnBestRating.Location = new System.Drawing.Point(491, 134);
            this.btnBestRating.Name = "btnBestRating";
            this.btnBestRating.Size = new System.Drawing.Size(110, 23);
            this.btnBestRating.TabIndex = 4;
            this.btnBestRating.Text = "Best Rating";
            this.btnBestRating.UseVisualStyleBackColor = true;
            this.btnBestRating.Click += new System.EventHandler(this.btnBestRating_Click);
            // 
            // btnWorstRating
            // 
            this.btnWorstRating.Location = new System.Drawing.Point(491, 177);
            this.btnWorstRating.Name = "btnWorstRating";
            this.btnWorstRating.Size = new System.Drawing.Size(110, 23);
            this.btnWorstRating.TabIndex = 5;
            this.btnWorstRating.Text = "Worst Rating";
            this.btnWorstRating.UseVisualStyleBackColor = true;
            this.btnWorstRating.Click += new System.EventHandler(this.btnWorstRating_Click);
            // 
            // btnSortByRating
            // 
            this.btnSortByRating.Location = new System.Drawing.Point(491, 220);
            this.btnSortByRating.Name = "btnSortByRating";
            this.btnSortByRating.Size = new System.Drawing.Size(110, 23);
            this.btnSortByRating.TabIndex = 6;
            this.btnSortByRating.Text = "Sort By Rating";
            this.btnSortByRating.UseVisualStyleBackColor = true;
            this.btnSortByRating.Click += new System.EventHandler(this.btnSortByRating_Click);
            // 
            // btnAverageRating
            // 
            this.btnAverageRating.Location = new System.Drawing.Point(491, 263);
            this.btnAverageRating.Name = "btnAverageRating";
            this.btnAverageRating.Size = new System.Drawing.Size(110, 23);
            this.btnAverageRating.TabIndex = 7;
            this.btnAverageRating.Text = "Average Rating";
            this.btnAverageRating.UseVisualStyleBackColor = true;
            this.btnAverageRating.Click += new System.EventHandler(this.btnAverageRating_Click);
            // 
            // btnAboveAverage
            // 
            this.btnAboveAverage.Location = new System.Drawing.Point(491, 307);
            this.btnAboveAverage.Name = "btnAboveAverage";
            this.btnAboveAverage.Size = new System.Drawing.Size(110, 23);
            this.btnAboveAverage.TabIndex = 8;
            this.btnAboveAverage.Text = "Above Average";
            this.btnAboveAverage.UseVisualStyleBackColor = true;
            this.btnAboveAverage.Click += new System.EventHandler(this.btnAboveAverage_Click);
            // 
            // btnBelowAverage
            // 
            this.btnBelowAverage.Location = new System.Drawing.Point(491, 352);
            this.btnBelowAverage.Name = "btnBelowAverage";
            this.btnBelowAverage.Size = new System.Drawing.Size(110, 23);
            this.btnBelowAverage.TabIndex = 9;
            this.btnBelowAverage.Text = "Below Average";
            this.btnBelowAverage.UseVisualStyleBackColor = true;
            this.btnBelowAverage.Click += new System.EventHandler(this.btnBelowAverage_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 241);
            this.dataGridView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Employee Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(392, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee Rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBelowAverage);
            this.Controls.Add(this.btnAboveAverage);
            this.Controls.Add(this.btnAverageRating);
            this.Controls.Add(this.btnSortByRating);
            this.Controls.Add(this.btnWorstRating);
            this.Controls.Add(this.btnBestRating);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnBestRating;
        private System.Windows.Forms.Button btnWorstRating;
        private System.Windows.Forms.Button btnSortByRating;
        private System.Windows.Forms.Button btnAverageRating;
        private System.Windows.Forms.Button btnAboveAverage;
        private System.Windows.Forms.Button btnBelowAverage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

