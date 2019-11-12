namespace fun_with_loops
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.questionLabel1 = new System.Windows.Forms.Label();
            this.questionLabel2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.inputLabel1 = new System.Windows.Forms.TextBox();
            this.inputLabel2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "start num, and end num";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fireworks Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "Square Generator";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // questionLabel1
            // 
            this.questionLabel1.AutoSize = true;
            this.questionLabel1.Location = new System.Drawing.Point(141, 45);
            this.questionLabel1.Name = "questionLabel1";
            this.questionLabel1.Size = new System.Drawing.Size(259, 25);
            this.questionLabel1.TabIndex = 5;
            this.questionLabel1.Text = "Choose a starting number";
            // 
            // questionLabel2
            // 
            this.questionLabel2.AutoSize = true;
            this.questionLabel2.Location = new System.Drawing.Point(141, 95);
            this.questionLabel2.Name = "questionLabel2";
            this.questionLabel2.Size = new System.Drawing.Size(265, 25);
            this.questionLabel2.TabIndex = 6;
            this.questionLabel2.Text = "Choose an ending number";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 56);
            this.button4.TabIndex = 9;
            this.button4.Text = "Show Values";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(39, 251);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(596, 82);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.Visible = false;
            // 
            // inputLabel1
            // 
            this.inputLabel1.Location = new System.Drawing.Point(407, 45);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(100, 31);
            this.inputLabel1.TabIndex = 11;
            // 
            // inputLabel2
            // 
            this.inputLabel2.Location = new System.Drawing.Point(407, 88);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(100, 31);
            this.inputLabel2.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(13, 309);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(250, 77);
            this.button5.TabIndex = 13;
            this.button5.Text = "Not Gambling";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 398);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.inputLabel2);
            this.Controls.Add(this.inputLabel1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.questionLabel2);
            this.Controls.Add(this.questionLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label questionLabel1;
        private System.Windows.Forms.Label questionLabel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox inputLabel1;
        private System.Windows.Forms.TextBox inputLabel2;
        private System.Windows.Forms.Button button5;
    }
}

