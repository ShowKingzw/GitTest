namespace WinFormsApp1
{
    partial class Form2
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
            this.textBoxTimes = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonRest = new System.Windows.Forms.Button();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTimes
            // 
            this.textBoxTimes.Location = new System.Drawing.Point(189, 174);
            this.textBoxTimes.Name = "textBoxTimes";
            this.textBoxTimes.Size = new System.Drawing.Size(208, 30);
            this.textBoxTimes.TabIndex = 15;
            this.textBoxTimes.TextChanged += new System.EventHandler(this.textBoxSum_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEnter.Location = new System.Drawing.Point(246, 238);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(151, 48);
            this.buttonEnter.TabIndex = 14;
            this.buttonEnter.Text = "Enter";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonRest
            // 
            this.buttonRest.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRest.Location = new System.Drawing.Point(71, 236);
            this.buttonRest.Name = "buttonRest";
            this.buttonRest.Size = new System.Drawing.Size(123, 50);
            this.buttonRest.TabIndex = 13;
            this.buttonRest.Text = "Rest";
            this.buttonRest.UseVisualStyleBackColor = true;
            this.buttonRest.Click += new System.EventHandler(this.buttonRest_Click);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(189, 113);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(208, 30);
            this.textBoxY.TabIndex = 12;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(189, 49);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(208, 30);
            this.textBoxX.TabIndex = 11;
            // 
            // labelX
            // 
            this.labelX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelX.Location = new System.Drawing.Point(71, 52);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(100, 23);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "X";
            this.labelX.Click += new System.EventHandler(this.labelX_Click);
            // 
            // labelY
            // 
            this.labelY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelY.Location = new System.Drawing.Point(71, 113);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(100, 23);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "Y";
            // 
            // labelSum
            // 
            this.labelSum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSum.Location = new System.Drawing.Point(71, 180);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(100, 23);
            this.labelSum.TabIndex = 8;
            this.labelSum.Text = "Times";
            this.labelSum.Click += new System.EventHandler(this.labelSum_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 333);
            this.Controls.Add(this.textBoxTimes);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.buttonRest);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelSum);
            this.Name = "Form2";
            this.Text = "Times Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxTimes;
        private Button buttonEnter;
        private Button buttonRest;
        private TextBox textBoxY;
        private TextBox textBoxX;
        private Label labelX;
        private Label labelY;
        private Label labelSum;
    }
}