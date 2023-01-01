namespace Wedding.Edited.Controlers
{
    partial class CalControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCal = new System.Windows.Forms.Label();
            this.txtcount = new System.Windows.Forms.TextBox();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "تعداد";
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Location = new System.Drawing.Point(88, 422);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(67, 20);
            this.lblCal.TabIndex = 8;
            this.lblCal.Text = "قیمت کل";
            // 
            // txtcount
            // 
            this.txtcount.Location = new System.Drawing.Point(168, 448);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(125, 27);
            this.txtcount.TabIndex = 5;
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(168, 415);
            this.txtCal.Name = "txtCal";
            this.txtCal.Size = new System.Drawing.Size(125, 27);
            this.txtCal.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "محاسبه قیمت کل";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CalControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.button1);
            this.Name = "CalControl1";
            this.Size = new System.Drawing.Size(414, 557);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal Label label2;
        internal Label lblCal;
        internal TextBox txtcount;
        internal TextBox txtCal;
        internal Button button1;
    }
}
