namespace 坐标正算
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxEdge = new System.Windows.Forms.TextBox();
            this.labelEdge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(134, 61);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(23, 15);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "X1";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(370, 61);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(23, 15);
            this.labelY1.TabIndex = 1;
            this.labelY1.Text = "Y1";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(205, 59);
            this.textBoxX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(135, 25);
            this.textBoxX1.TabIndex = 2;
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // textBoxY1
            // 
            this.textBoxY1.Location = new System.Drawing.Point(442, 59);
            this.textBoxY1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(134, 25);
            this.textBoxY1.TabIndex = 3;
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Location = new System.Drawing.Point(134, 129);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(82, 15);
            this.labela.TabIndex = 4;
            this.labela.Text = "坐标方位角";
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(250, 126);
            this.textBoxa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(89, 25);
            this.textBoxa.TabIndex = 5;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(442, 211);
            this.textBoxY2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(134, 25);
            this.textBoxY2.TabIndex = 9;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(205, 214);
            this.textBoxX2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(135, 25);
            this.textBoxX2.TabIndex = 8;
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(370, 214);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(23, 15);
            this.labelY2.TabIndex = 7;
            this.labelY2.Text = "Y2";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(134, 214);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(23, 15);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "X2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(413, 277);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "计算";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxEdge
            // 
            this.textBoxEdge.Location = new System.Drawing.Point(442, 129);
            this.textBoxEdge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEdge.Name = "textBoxEdge";
            this.textBoxEdge.Size = new System.Drawing.Size(135, 25);
            this.textBoxEdge.TabIndex = 13;
            // 
            // labelEdge
            // 
            this.labelEdge.AutoSize = true;
            this.labelEdge.Location = new System.Drawing.Point(370, 129);
            this.labelEdge.Name = "labelEdge";
            this.labelEdge.Size = new System.Drawing.Size(22, 15);
            this.labelEdge.TabIndex = 12;
            this.labelEdge.Text = "边";
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.textBoxEdge);
            this.Controls.Add(this.labelEdge);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.labela);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "坐标正算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.TextBox textBoxa;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxEdge;
        private System.Windows.Forms.Label labelEdge;
    }
}

