namespace Test_C_
{
    partial class BitMap
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
            Guna.UI2.WinForms.Suite.TextBoxState textBoxState5 = new Guna.UI2.WinForms.Suite.TextBoxState();
            this.ctrlFramedTextBox1 = new MyUC.ctrlFramedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlHead
            // 
            this.PnlHead.MinimumSize = new System.Drawing.Size(0, 94);
            this.PnlHead.Size = new System.Drawing.Size(932, 94);
            this.PnlHead.Controls.SetChildIndex(this.lblTime, 0);
            this.PnlHead.Controls.SetChildIndex(this.lnkUsername, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbProPic, 0);
            this.PnlHead.Controls.SetChildIndex(this.pbStar, 0);
            // 
            // pbStar
            // 
            this.pbStar.Location = new System.Drawing.Point(0, 0);
            this.pbStar.Size = new System.Drawing.Size(94, 94);
            // 
            // pbProPic
            // 
            this.pbProPic.Location = new System.Drawing.Point(363, 1);
            // 
            // lnkUsername
            // 
            this.lnkUsername.Location = new System.Drawing.Point(464, 10);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(770, 8);
            // 
            // ctrlFramedTextBox1
            // 
            this.ctrlFramedTextBox1.BackColor = System.Drawing.Color.Transparent;
            textBoxState5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctrlFramedTextBox1.FocusedState = textBoxState5;
            this.ctrlFramedTextBox1.HName = "tb";
            this.ctrlFramedTextBox1.Location = new System.Drawing.Point(209, 253);
            this.ctrlFramedTextBox1.Max = ((short)(100));
            this.ctrlFramedTextBox1.Min = ((short)(0));
            this.ctrlFramedTextBox1.Mode = MyUC.ctrlFramedTextBox.enMode.Email;
            this.ctrlFramedTextBox1.Name = "ctrlFramedTextBox1";
            this.ctrlFramedTextBox1.Size = new System.Drawing.Size(249, 56);
            this.ctrlFramedTextBox1.TabIndex = 1;
            this.ctrlFramedTextBox1.Leave += new System.EventHandler(this.ctrlFramedTextBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // BitMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 615);
            this.Controls.Add(this.ctrlFramedTextBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(0, 94);
            this.Mode = MyUC.Forms.frmScreen.enMode.User;
            this.Name = "BitMap";
            this.Text = "BitMap";
            this.Username = "Osama";
            this.UsernameClicked += new System.EventHandler(this.BitMap_UsernameClicked);
            this.Controls.SetChildIndex(this.PnlHead, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ctrlFramedTextBox1, 0);
            this.PnlHead.ResumeLayout(false);
            this.PnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyUC.ctrlFramedTextBox ctrlFramedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}