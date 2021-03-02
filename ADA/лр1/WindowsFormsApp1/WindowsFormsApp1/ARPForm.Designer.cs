namespace WindowsFormsApp1
{
    partial class ARPForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.MACtextBox = new System.Windows.Forms.TextBox();
            this.aradioButton1 = new System.Windows.Forms.RadioButton();
            this.sradioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 49);
            this.button1.TabIndex = 20;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 193);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(776, 245);
            this.textBox1.TabIndex = 19;
            // 
            // IPtextBox
            // 
            this.IPtextBox.Location = new System.Drawing.Point(12, 59);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(100, 20);
            this.IPtextBox.TabIndex = 23;
            this.IPtextBox.Text = "IP";
            // 
            // MACtextBox
            // 
            this.MACtextBox.Location = new System.Drawing.Point(12, 85);
            this.MACtextBox.Name = "MACtextBox";
            this.MACtextBox.Size = new System.Drawing.Size(100, 20);
            this.MACtextBox.TabIndex = 24;
            this.MACtextBox.Text = "MAC";
            // 
            // aradioButton1
            // 
            this.aradioButton1.AutoSize = true;
            this.aradioButton1.Location = new System.Drawing.Point(12, 13);
            this.aradioButton1.Name = "aradioButton1";
            this.aradioButton1.Size = new System.Drawing.Size(34, 17);
            this.aradioButton1.TabIndex = 25;
            this.aradioButton1.TabStop = true;
            this.aradioButton1.Text = "-a";
            this.aradioButton1.UseVisualStyleBackColor = true;
            // 
            // sradioButton2
            // 
            this.sradioButton2.AutoSize = true;
            this.sradioButton2.Location = new System.Drawing.Point(12, 36);
            this.sradioButton2.Name = "sradioButton2";
            this.sradioButton2.Size = new System.Drawing.Size(33, 17);
            this.sradioButton2.TabIndex = 26;
            this.sradioButton2.TabStop = true;
            this.sradioButton2.Text = "-s";
            this.sradioButton2.UseVisualStyleBackColor = true;
            // 
            // ARPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sradioButton2);
            this.Controls.Add(this.aradioButton1);
            this.Controls.Add(this.MACtextBox);
            this.Controls.Add(this.IPtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "ARPForm";
            this.Text = "ARPForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.TextBox MACtextBox;
        private System.Windows.Forms.RadioButton aradioButton1;
        private System.Windows.Forms.RadioButton sradioButton2;
    }
}