namespace Test_C_
{
    partial class frmDataTable
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            this.statPie1 = new MyUC.StatPie();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AllowUserToOrderColumns = true;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(528, 379);
            this.dgv1.TabIndex = 0;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(637, 103);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Sort Desc";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // statPie1
            // 
            this.statPie1.Location = new System.Drawing.Point(745, 70);
            this.statPie1.Name = "statPie1";
            this.statPie1.Part = 57F;
            this.statPie1.PartColor = System.Drawing.Color.Crimson;
            this.statPie1.PartName = "Osama\'s Salary";
            this.statPie1.Size = new System.Drawing.Size(228, 296);
            this.statPie1.TabIndex = 2;
            this.statPie1.Total = 80F;
            this.statPie1.TotalColor = System.Drawing.Color.Orange;
            this.statPie1.TotalName = "Total Salary";
            // 
            // frmDataTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.statPie1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dgv1);
            this.Name = "frmDataTable";
            this.Text = "frmDataTable";
            this.Load += new System.EventHandler(this.frmDataTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnSort;
        private MyUC.StatPie statPie1;
    }
}