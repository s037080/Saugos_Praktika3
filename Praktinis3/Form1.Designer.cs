
namespace Praktinis3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actionButton = new System.Windows.Forms.Button();
            this.passwordBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.encryptButton = new System.Windows.Forms.RadioButton();
            this.decryptButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text:";
            // 
            // actionButton
            // 
            this.actionButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.actionButton.Location = new System.Drawing.Point(111, 274);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(107, 33);
            this.actionButton.TabIndex = 2;
            this.actionButton.Text = "Start";
            this.actionButton.UseVisualStyleBackColor = false;
            this.actionButton.Click += new System.EventHandler(this.actionButton_Click);
            // 
            // passwordBox1
            // 
            this.passwordBox1.Location = new System.Drawing.Point(40, 129);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Size = new System.Drawing.Size(230, 20);
            this.passwordBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(40, 235);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(230, 20);
            this.resultBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Result:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(281, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseButton.Location = new System.Drawing.Point(281, 72);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(28, 23);
            this.browseButton.TabIndex = 12;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = false;
            // 
            // encryptButton
            // 
            this.encryptButton.AutoSize = true;
            this.encryptButton.Location = new System.Drawing.Point(40, 155);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(61, 17);
            this.encryptButton.TabIndex = 13;
            this.encryptButton.TabStop = true;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            // 
            // decryptButton
            // 
            this.decryptButton.AutoSize = true;
            this.decryptButton.Location = new System.Drawing.Point(111, 155);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(62, 17);
            this.decryptButton.TabIndex = 14;
            this.decryptButton.TabStop = true;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(404, 335);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox1);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Praktika3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button actionButton;
        private System.Windows.Forms.TextBox passwordBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.RadioButton encryptButton;
        private System.Windows.Forms.RadioButton decryptButton;
    }
}

