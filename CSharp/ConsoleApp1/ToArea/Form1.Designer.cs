namespace ToArea
{
    partial class HomePage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.r = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Location = new System.Drawing.Point(119, 61);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(89, 18);
            this.r.TabIndex = 0;
            this.r.Text = "半径（R）";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "面积（S）";
            // 
            // rTextBox
            // 
            this.rTextBox.Location = new System.Drawing.Point(214, 51);
            this.rTextBox.Name = "rTextBox";
            this.rTextBox.Size = new System.Drawing.Size(207, 28);
            this.rTextBox.TabIndex = 2;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(214, 106);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(207, 28);
            this.areaTextBox.TabIndex = 3;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(148, 198);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(118, 38);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(286, 198);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(118, 38);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "计算";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // HomePage
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 297);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.rTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.Text = "面积计算";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button enterButton;
    }
}

