namespace WindowsFormsApp1
{
    partial class RouteForm
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
            this.FcheckBox = new System.Windows.Forms.CheckBox();
            this.PcheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PradioButton = new System.Windows.Forms.RadioButton();
            this.AradioButton = new System.Windows.Forms.RadioButton();
            this.DradioButton = new System.Windows.Forms.RadioButton();
            this.CradioButton = new System.Windows.Forms.RadioButton();
            this.MradioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
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
            // FcheckBox
            // 
            this.FcheckBox.AutoSize = true;
            this.FcheckBox.Location = new System.Drawing.Point(12, 12);
            this.FcheckBox.Name = "FcheckBox";
            this.FcheckBox.Size = new System.Drawing.Size(32, 17);
            this.FcheckBox.TabIndex = 25;
            this.FcheckBox.Text = "-f";
            this.FcheckBox.UseVisualStyleBackColor = true;
            // 
            // PcheckBox
            // 
            this.PcheckBox.AutoSize = true;
            this.PcheckBox.Location = new System.Drawing.Point(50, 12);
            this.PcheckBox.Name = "PcheckBox";
            this.PcheckBox.Size = new System.Drawing.Size(35, 17);
            this.PcheckBox.TabIndex = 26;
            this.PcheckBox.Text = "-p";
            this.PcheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Command:";
            // 
            // PradioButton
            // 
            this.PradioButton.AutoSize = true;
            this.PradioButton.Location = new System.Drawing.Point(12, 49);
            this.PradioButton.Name = "PradioButton";
            this.PradioButton.Size = new System.Drawing.Size(46, 17);
            this.PradioButton.TabIndex = 28;
            this.PradioButton.TabStop = true;
            this.PradioButton.Text = "Print";
            this.PradioButton.UseVisualStyleBackColor = true;
            // 
            // AradioButton
            // 
            this.AradioButton.AutoSize = true;
            this.AradioButton.Location = new System.Drawing.Point(12, 72);
            this.AradioButton.Name = "AradioButton";
            this.AradioButton.Size = new System.Drawing.Size(44, 17);
            this.AradioButton.TabIndex = 29;
            this.AradioButton.TabStop = true;
            this.AradioButton.Text = "Add";
            this.AradioButton.UseVisualStyleBackColor = true;
            // 
            // DradioButton
            // 
            this.DradioButton.AutoSize = true;
            this.DradioButton.Location = new System.Drawing.Point(12, 95);
            this.DradioButton.Name = "DradioButton";
            this.DradioButton.Size = new System.Drawing.Size(56, 17);
            this.DradioButton.TabIndex = 30;
            this.DradioButton.TabStop = true;
            this.DradioButton.Text = "Delete";
            this.DradioButton.UseVisualStyleBackColor = true;
            // 
            // CradioButton
            // 
            this.CradioButton.AutoSize = true;
            this.CradioButton.Location = new System.Drawing.Point(12, 118);
            this.CradioButton.Name = "CradioButton";
            this.CradioButton.Size = new System.Drawing.Size(62, 17);
            this.CradioButton.TabIndex = 31;
            this.CradioButton.TabStop = true;
            this.CradioButton.Text = "Change";
            this.CradioButton.UseVisualStyleBackColor = true;
            // 
            // MradioButton
            // 
            this.MradioButton.AutoSize = true;
            this.MradioButton.Location = new System.Drawing.Point(12, 141);
            this.MradioButton.Name = "MradioButton";
            this.MradioButton.Size = new System.Drawing.Size(54, 17);
            this.MradioButton.TabIndex = 32;
            this.MradioButton.TabStop = true;
            this.MradioButton.Text = "Metric";
            this.MradioButton.UseVisualStyleBackColor = true;
            // 
            // RouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MradioButton);
            this.Controls.Add(this.CradioButton);
            this.Controls.Add(this.DradioButton);
            this.Controls.Add(this.AradioButton);
            this.Controls.Add(this.PradioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PcheckBox);
            this.Controls.Add(this.FcheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "RouteForm";
            this.Text = "RouteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox FcheckBox;
        private System.Windows.Forms.CheckBox PcheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton PradioButton;
        private System.Windows.Forms.RadioButton AradioButton;
        private System.Windows.Forms.RadioButton DradioButton;
        private System.Windows.Forms.RadioButton CradioButton;
        private System.Windows.Forms.RadioButton MradioButton;
    }
}