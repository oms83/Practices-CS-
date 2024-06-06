namespace Event_Args_And_Delegates_And_Events
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
            this.ctrlCalculate1 = new Event_Args_And_Delegates_And_Events.Forms.User_Controls.ctrlCalculate();
            this.SuspendLayout();
            // 
            // ctrlCalculate1
            // 
            this.ctrlCalculate1.Location = new System.Drawing.Point(152, 72);
            this.ctrlCalculate1.Name = "ctrlCalculate1";
            this.ctrlCalculate1.Size = new System.Drawing.Size(257, 129);
            this.ctrlCalculate1.TabIndex = 0;
            this.ctrlCalculate1.OnCalculationComplate += new System.EventHandler<Event_Args_And_Delegates_And_Events.Forms.User_Controls.ctrlCalculate.CalculateEventArgs>(this.ctrlCalculate1_OnCalculationComplate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlCalculate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.User_Controls.ctrlCalculate ctrlCalculate1;
    }
}