namespace GeckofxUnitTests.Forms
{
    partial class UnitTestBrowser
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.wbUnitTest = new Gecko.GeckoWebBrowser();
            this.wbMemory = new Gecko.GeckoWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.wbUnitTest);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.wbMemory);
            this.splitMain.Size = new System.Drawing.Size(989, 553);
            this.splitMain.SplitterDistance = 682;
            this.splitMain.TabIndex = 1;
            // 
            // wbUnitTest
            // 
            this.wbUnitTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbUnitTest.Location = new System.Drawing.Point(0, 0);
            this.wbUnitTest.Name = "wbUnitTest";
            this.wbUnitTest.Size = new System.Drawing.Size(682, 553);
            this.wbUnitTest.TabIndex = 0;
            this.wbUnitTest.UseHttpActivityObserver = false;
            // 
            // wbMemory
            // 
            this.wbMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMemory.Location = new System.Drawing.Point(0, 0);
            this.wbMemory.Name = "wbMemory";
            this.wbMemory.Size = new System.Drawing.Size(303, 553);
            this.wbMemory.TabIndex = 1;
            this.wbMemory.UseHttpActivityObserver = false;
            // 
            // UnitTestBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 553);
            this.Controls.Add(this.splitMain);
            this.Name = "UnitTestBrowser";
            this.Text = "Unit Test Browser";
            this.Load += new System.EventHandler(this.AboutMemory_Load);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        public Gecko.GeckoWebBrowser wbMemory;
        public Gecko.GeckoWebBrowser wbUnitTest;
    }
}