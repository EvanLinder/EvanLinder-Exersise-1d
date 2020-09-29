namespace WindowsFormsApp1
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.pictureBoxTwo = new System.Windows.Forms.PictureBox();
            this.pictureBoxThree = new System.Windows.Forms.PictureBox();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.textBoxOne = new System.Windows.Forms.TextBox();
            this.textBoxTwo = new System.Windows.Forms.TextBox();
            this.groupBoxOne = new System.Windows.Forms.GroupBox();
            this.groupBoxTwo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThree)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(191, 372);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(75, 23);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.Text = "button1";
            this.buttonOne.UseVisualStyleBackColor = true;
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(386, 372);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(75, 23);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.Text = "button2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(155, 67);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 50);
            this.picture.TabIndex = 2;
            this.picture.TabStop = false;
            // 
            // pictureBoxTwo
            // 
            this.pictureBoxTwo.Location = new System.Drawing.Point(337, 67);
            this.pictureBoxTwo.Name = "pictureBoxTwo";
            this.pictureBoxTwo.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxTwo.TabIndex = 3;
            this.pictureBoxTwo.TabStop = false;
            // 
            // pictureBoxThree
            // 
            this.pictureBoxThree.Location = new System.Drawing.Point(530, 67);
            this.pictureBoxThree.Name = "pictureBoxThree";
            this.pictureBoxThree.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxThree.TabIndex = 4;
            this.pictureBoxThree.TabStop = false;
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Location = new System.Drawing.Point(134, 175);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(51, 20);
            this.labelOne.TabIndex = 5;
            this.labelOne.Text = "label1";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Location = new System.Drawing.Point(136, 238);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(51, 20);
            this.labelTwo.TabIndex = 6;
            this.labelTwo.Text = "label2";
            // 
            // textBoxOne
            // 
            this.textBoxOne.Location = new System.Drawing.Point(439, 179);
            this.textBoxOne.Name = "textBoxOne";
            this.textBoxOne.Size = new System.Drawing.Size(100, 26);
            this.textBoxOne.TabIndex = 7;
            // 
            // textBoxTwo
            // 
            this.textBoxTwo.Location = new System.Drawing.Point(439, 238);
            this.textBoxTwo.Name = "textBoxTwo";
            this.textBoxTwo.Size = new System.Drawing.Size(100, 26);
            this.textBoxTwo.TabIndex = 8;
            // 
            // groupBoxOne
            // 
            this.groupBoxOne.Location = new System.Drawing.Point(12, 266);
            this.groupBoxOne.Name = "groupBoxOne";
            this.groupBoxOne.Size = new System.Drawing.Size(200, 100);
            this.groupBoxOne.TabIndex = 9;
            this.groupBoxOne.TabStop = false;
            this.groupBoxOne.Text = "groupBox1";
            // 
            // groupBoxTwo
            // 
            this.groupBoxTwo.Location = new System.Drawing.Point(405, 266);
            this.groupBoxTwo.Name = "groupBoxTwo";
            this.groupBoxTwo.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTwo.TabIndex = 10;
            this.groupBoxTwo.TabStop = false;
            this.groupBoxTwo.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTwo);
            this.Controls.Add(this.groupBoxOne);
            this.Controls.Add(this.textBoxTwo);
            this.Controls.Add(this.textBoxOne);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.pictureBoxThree);
            this.Controls.Add(this.pictureBoxTwo);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.PictureBox pictureBoxTwo;
        private System.Windows.Forms.PictureBox pictureBoxThree;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.TextBox textBoxOne;
        private System.Windows.Forms.TextBox textBoxTwo;
        private System.Windows.Forms.GroupBox groupBoxOne;
        private System.Windows.Forms.GroupBox groupBoxTwo;
    }
}

