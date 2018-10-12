namespace ImageScannerOCRApp
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
            this.inputImageTextbox = new System.Windows.Forms.TextBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.outputTextbox = new System.Windows.Forms.TextBox();
            this.scanButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputImageTextbox
            // 
            this.inputImageTextbox.Location = new System.Drawing.Point(12, 28);
            this.inputImageTextbox.Name = "inputImageTextbox";
            this.inputImageTextbox.Size = new System.Drawing.Size(506, 20);
            this.inputImageTextbox.TabIndex = 0;
            this.inputImageTextbox.Text = "Select Image to Scan";
            this.inputImageTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(12, 12);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(36, 13);
            this.imageLabel.TabIndex = 1;
            this.imageLabel.Text = "Image";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 79);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Output";
            // 
            // outputTextbox
            // 
            this.outputTextbox.Location = new System.Drawing.Point(15, 95);
            this.outputTextbox.Multiline = true;
            this.outputTextbox.Name = "outputTextbox";
            this.outputTextbox.ReadOnly = true;
            this.outputTextbox.Size = new System.Drawing.Size(605, 342);
            this.outputTextbox.TabIndex = 3;
            this.outputTextbox.TextChanged += new System.EventHandler(this.outputTextbox_TextChanged);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(527, 443);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(93, 21);
            this.scanButton.TabIndex = 5;
            this.scanButton.Text = "Scan!";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(524, 28);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(92, 21);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 476);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.outputTextbox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.inputImageTextbox);
            this.Name = "Form1";
            this.Text = "Image Scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputImageTextbox;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox outputTextbox;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.Button browseButton;
    }
}

