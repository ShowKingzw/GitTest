namespace WinFormsApp1
{
    partial class WinForm1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinForm1));
            this.labelSum = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSum
            // 
            resources.ApplyResources(this.labelSum, "labelSum");
            this.labelSum.Name = "labelSum";
            // 
            // labelY
            // 
            resources.ApplyResources(this.labelY, "labelY");
            this.labelY.Name = "labelY";
            this.labelY.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelX
            // 
            resources.ApplyResources(this.labelX, "labelX");
            this.labelX.Name = "labelX";
            this.labelX.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxX
            // 
            resources.ApplyResources(this.textBoxX, "textBoxX");
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxY
            // 
            resources.ApplyResources(this.textBoxY, "textBoxY");
            this.textBoxY.Name = "textBoxY";
            // 
            // buttonSwitch
            // 
            resources.ApplyResources(this.buttonSwitch, "buttonSwitch");
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.Form1_Load);
            // 
            // buttonEnter
            // 
            resources.ApplyResources(this.buttonEnter, "buttonEnter");
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxSum
            // 
            resources.ApplyResources(this.textBoxSum, "textBoxSum");
            this.textBoxSum.Name = "textBoxSum";
            // 
            // WinForm1
            // 
            this.AcceptButton = this.buttonEnter;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelSum);
            this.Name = "WinForm1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelSum;
        private Label labelY;
        private Label labelX;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Button buttonSwitch;
        private Button buttonEnter;
        private TextBox textBoxSum;
    }
}