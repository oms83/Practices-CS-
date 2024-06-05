namespace Multicast_Delegates.Data_Back
{
    partial class frmDataBackByEvent
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
            this.btnBackData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackData
            // 
            this.btnBackData.Location = new System.Drawing.Point(412, 209);
            this.btnBackData.Name = "btnBackData";
            this.btnBackData.Size = new System.Drawing.Size(114, 33);
            this.btnBackData.TabIndex = 3;
            this.btnBackData.Text = "Back Data";
            this.btnBackData.UseVisualStyleBackColor = true;
            this.btnBackData.Click += new System.EventHandler(this.btnBackData_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 22);
            this.textBox1.TabIndex = 2;
            // 
            // frmDataBackByEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackData);
            this.Controls.Add(this.textBox1);
            this.Name = "frmDataBackByEvent";
            this.Text = "frmDataBackByEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackData;
        private System.Windows.Forms.TextBox textBox1;
    }
}