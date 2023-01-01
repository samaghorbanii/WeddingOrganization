namespace Wedding.Edited.ValueControler
{
    partial class ValueControl
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
            this.gpPropertyValue = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.picValue = new System.Windows.Forms.PictureBox();
            this.gpPropertyValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValue)).BeginInit();
            this.SuspendLayout();
            // 
            // gpPropertyValue
            // 
            this.gpPropertyValue.Controls.Add(this.lblCount);
            this.gpPropertyValue.Controls.Add(this.txtCount);
            this.gpPropertyValue.Controls.Add(this.picValue);
            this.gpPropertyValue.Location = new System.Drawing.Point(0, 0);
            this.gpPropertyValue.Name = "gpPropertyValue";
            this.gpPropertyValue.Size = new System.Drawing.Size(357, 394);
            this.gpPropertyValue.TabIndex = 0;
            this.gpPropertyValue.TabStop = false;
            this.gpPropertyValue.Text = "Value";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(100, 344);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(51, 20);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Count:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(168, 337);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(98, 27);
            this.txtCount.TabIndex = 1;
            // 
            // picValue
            // 
            this.picValue.Location = new System.Drawing.Point(61, 26);
            this.picValue.Name = "picValue";
            this.picValue.Size = new System.Drawing.Size(205, 159);
            this.picValue.TabIndex = 0;
            this.picValue.TabStop = false;
            // 
            // ValueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpPropertyValue);
            this.Name = "ValueControl";
            this.Size = new System.Drawing.Size(363, 401);
            this.gpPropertyValue.ResumeLayout(false);
            this.gpPropertyValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal GroupBox gpPropertyValue;
        internal PictureBox picValue;
        internal Label lblCount;
        internal TextBox txtCount;
    }
}
