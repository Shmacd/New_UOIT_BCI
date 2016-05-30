namespace EEG
{
    partial class Main
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
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTally = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 99);
            this.button1.TabIndex = 1;
            this.button1.Text = "Begin Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 99);
            this.button3.TabIndex = 3;
            this.button3.Text = "Complex Password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(160, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 99);
            this.button5.TabIndex = 5;
            this.button5.Text = "Setup Test Space";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnTally
            // 
            this.btnTally.Location = new System.Drawing.Point(367, 236);
            this.btnTally.Name = "btnTally";
            this.btnTally.Size = new System.Drawing.Size(120, 99);
            this.btnTally.TabIndex = 6;
            this.btnTally.Text = "Tally Results";
            this.btnTally.UseVisualStyleBackColor = true;
            this.btnTally.Click += new System.EventHandler(this.btnTally_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 476);
            this.Controls.Add(this.btnTally);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTally;

    }
}