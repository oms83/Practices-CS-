namespace Multicast_Delegates.Data_Back
{
    partial class frmDataBack
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBackData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnBackData
            // 
            this.btnBackData.Location = new System.Drawing.Point(303, 89);
            this.btnBackData.Name = "btnBackData";
            this.btnBackData.Size = new System.Drawing.Size(114, 33);
            this.btnBackData.TabIndex = 1;
            this.btnBackData.Text = "Back Data";
            this.btnBackData.UseVisualStyleBackColor = true;
            this.btnBackData.Click += new System.EventHandler(this.btnBackData_Click);
            // 
            // frmDataBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 245);
            this.Controls.Add(this.btnBackData);
            this.Controls.Add(this.textBox1);
            this.Name = "frmDataBack";
            this.Text = "frmDataBack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBackData;
    }
}