namespace lol
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
            this.calcButton = new System.Windows.Forms.Button();
            this.inputTextBox4 = new System.Windows.Forms.TextBox();
            this.inputTextBox3 = new System.Windows.Forms.TextBox();
            this.inputTextBox2 = new System.Windows.Forms.TextBox();
            this.inputTextBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextBox5 = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 327);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(106, 33);
            this.calcButton.TabIndex = 29;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // inputTextBox4
            // 
            this.inputTextBox4.Location = new System.Drawing.Point(607, 120);
            this.inputTextBox4.Name = "inputTextBox4";
            this.inputTextBox4.Size = new System.Drawing.Size(148, 26);
            this.inputTextBox4.TabIndex = 25;
            this.inputTextBox4.TextChanged += new System.EventHandler(this.resultTextBox1c_TextChanged);
            // 
            // inputTextBox3
            // 
            this.inputTextBox3.Location = new System.Drawing.Point(454, 120);
            this.inputTextBox3.Name = "inputTextBox3";
            this.inputTextBox3.Size = new System.Drawing.Size(137, 26);
            this.inputTextBox3.TabIndex = 24;
            this.inputTextBox3.TextChanged += new System.EventHandler(this.resultTextBox1b_TextChanged);
            // 
            // inputTextBox2
            // 
            this.inputTextBox2.Location = new System.Drawing.Point(259, 120);
            this.inputTextBox2.Name = "inputTextBox2";
            this.inputTextBox2.Size = new System.Drawing.Size(156, 26);
            this.inputTextBox2.TabIndex = 23;
            this.inputTextBox2.TextChanged += new System.EventHandler(this.resultTextBox1a_TextChanged);
            // 
            // inputTextBox1
            // 
            this.inputTextBox1.Location = new System.Drawing.Point(74, 120);
            this.inputTextBox1.Name = "inputTextBox1";
            this.inputTextBox1.Size = new System.Drawing.Size(138, 26);
            this.inputTextBox1.TabIndex = 22;
            this.inputTextBox1.TextChanged += new System.EventHandler(this.inputTextBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "resultTextBox1c";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "resultTextBox1b";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "resultTextBox1a";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "inputTextBox1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputTextBox5
            // 
            this.inputTextBox5.Location = new System.Drawing.Point(75, 189);
            this.inputTextBox5.Name = "inputTextBox5";
            this.inputTextBox5.Size = new System.Drawing.Size(137, 26);
            this.inputTextBox5.TabIndex = 31;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(370, 291);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(355, 26);
            this.resultTextBox.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inputTextBox5);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.inputTextBox4);
            this.Controls.Add(this.inputTextBox3);
            this.Controls.Add(this.inputTextBox2);
            this.Controls.Add(this.inputTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox inputTextBox4;
        private System.Windows.Forms.TextBox inputTextBox3;
        private System.Windows.Forms.TextBox inputTextBox2;
        private System.Windows.Forms.TextBox inputTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextBox5;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

