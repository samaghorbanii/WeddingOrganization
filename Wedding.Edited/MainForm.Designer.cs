namespace Wedding.Edited
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ServiceMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Foods = new System.Windows.Forms.ToolStripMenuItem();
            this.editService = new System.Windows.Forms.ToolStripMenuItem();
            this.Addservice = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServiceMenu,
            this.editService});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ServiceMenu
            // 
            this.ServiceMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Foods});
            this.ServiceMenu.Name = "ServiceMenu";
            this.ServiceMenu.Size = new System.Drawing.Size(89, 24);
            this.ServiceMenu.Text = "سرویس ها";
            // 
            // Foods
            // 
            this.Foods.Name = "Foods";
            this.Foods.Size = new System.Drawing.Size(131, 26);
            this.Foods.Text = "غذا ها";
            this.Foods.Click += new System.EventHandler(this.Foods_Click);
            // 
            // editService
            // 
            this.editService.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addservice});
            this.editService.Name = "editService";
            this.editService.Size = new System.Drawing.Size(139, 24);
            this.editService.Text = "ویرایش سرویس ها";
            // 
            // Addservice
            // 
            this.Addservice.Name = "Addservice";
            this.Addservice.Size = new System.Drawing.Size(224, 26);
            this.Addservice.Text = "اضافه کردن";
            this.Addservice.Click += new System.EventHandler(this.Addservice_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ServiceMenu;
        private ToolStripMenuItem Foods;
        private ToolStripMenuItem editService;
        private ToolStripMenuItem Addservice;
    }
}