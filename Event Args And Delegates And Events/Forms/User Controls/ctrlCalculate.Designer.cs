namespace Event_Args_And_Delegates_And_Events.Forms.User_Controls
{
    partial class ctrlCalculate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(48, 25);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 22);
            this.txtValue1.TabIndex = 0;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(48, 62);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 22);
            this.txtValue2.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(104, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(15, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "--";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(154, 46);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "sum";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // ctrlCalculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Name = "ctrlCalculate";
            this.Size = new System.Drawing.Size(257, 129);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
    }
}
