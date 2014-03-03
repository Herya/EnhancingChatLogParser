namespace Enhancing_ChatLog_Parser
{
    partial class TextInputer
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
            this.descriptionSuccessLabel = new System.Windows.Forms.Label();
            this.inputSuccessTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.descriptionFailLabel = new System.Windows.Forms.Label();
            this.inputFailTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // descriptionSuccessLabel
            // 
            this.descriptionSuccessLabel.AutoSize = true;
            this.descriptionSuccessLabel.Location = new System.Drawing.Point(6, 24);
            this.descriptionSuccessLabel.Name = "descriptionSuccessLabel";
            this.descriptionSuccessLabel.Size = new System.Drawing.Size(54, 13);
            this.descriptionSuccessLabel.TabIndex = 0;
            this.descriptionSuccessLabel.Text = "Success :";
            // 
            // inputSuccessTextBox
            // 
            this.inputSuccessTextBox.Location = new System.Drawing.Point(61, 21);
            this.inputSuccessTextBox.Name = "inputSuccessTextBox";
            this.inputSuccessTextBox.Size = new System.Drawing.Size(317, 20);
            this.inputSuccessTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(392, 36);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(43, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // descriptionFailLabel
            // 
            this.descriptionFailLabel.AutoSize = true;
            this.descriptionFailLabel.Location = new System.Drawing.Point(9, 63);
            this.descriptionFailLabel.Name = "descriptionFailLabel";
            this.descriptionFailLabel.Size = new System.Drawing.Size(29, 13);
            this.descriptionFailLabel.TabIndex = 3;
            this.descriptionFailLabel.Text = "Fail :";
            this.descriptionFailLabel.Click += new System.EventHandler(this.descriptionFailLabel_Click);
            // 
            // inputFailTextBox
            // 
            this.inputFailTextBox.Location = new System.Drawing.Point(61, 55);
            this.inputFailTextBox.Name = "inputFailTextBox";
            this.inputFailTextBox.Size = new System.Drawing.Size(317, 20);
            this.inputFailTextBox.TabIndex = 4;
            // 
            // TextInputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 91);
            this.Controls.Add(this.inputFailTextBox);
            this.Controls.Add(this.descriptionFailLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inputSuccessTextBox);
            this.Controls.Add(this.descriptionSuccessLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextInputer";
            this.Text = "Text Inputer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionSuccessLabel;
        private System.Windows.Forms.TextBox inputSuccessTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label descriptionFailLabel;
        private System.Windows.Forms.TextBox inputFailTextBox;
    }
}