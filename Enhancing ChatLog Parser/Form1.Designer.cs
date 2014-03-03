namespace Enhancing_ChatLog_Parser
{
    partial class ChatLogParser
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
            this.selectFileButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            this.failLabel = new System.Windows.Forms.Label();
            this.totalLabelResult = new System.Windows.Forms.Label();
            this.successLabelResult = new System.Windows.Forms.Label();
            this.failLabelResult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.addButton = new System.Windows.Forms.Button();
            this.openTextInputerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(12, 12);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(99, 23);
            this.selectFileButton.TabIndex = 0;
            this.selectFileButton.Text = "Select Chat.log";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(134, 17);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(37, 13);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total :";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Location = new System.Drawing.Point(136, 54);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(49, 13);
            this.successLabel.TabIndex = 4;
            this.successLabel.Text = "Succès :";
            this.successLabel.Click += new System.EventHandler(this.successLabel_Click);
            // 
            // failLabel
            // 
            this.failLabel.AutoSize = true;
            this.failLabel.Location = new System.Drawing.Point(137, 91);
            this.failLabel.Name = "failLabel";
            this.failLabel.Size = new System.Drawing.Size(44, 13);
            this.failLabel.TabIndex = 5;
            this.failLabel.Text = "Echec :";
            this.failLabel.Click += new System.EventHandler(this.failLabel_Click);
            // 
            // totalLabelResult
            // 
            this.totalLabelResult.AutoSize = true;
            this.totalLabelResult.Location = new System.Drawing.Point(197, 17);
            this.totalLabelResult.Name = "totalLabelResult";
            this.totalLabelResult.Size = new System.Drawing.Size(0, 13);
            this.totalLabelResult.TabIndex = 6;
            // 
            // successLabelResult
            // 
            this.successLabelResult.AutoSize = true;
            this.successLabelResult.Location = new System.Drawing.Point(197, 54);
            this.successLabelResult.Name = "successLabelResult";
            this.successLabelResult.Size = new System.Drawing.Size(0, 13);
            this.successLabelResult.TabIndex = 7;
            // 
            // failLabelResult
            // 
            this.failLabelResult.AutoSize = true;
            this.failLabelResult.Location = new System.Drawing.Point(197, 91);
            this.failLabelResult.Name = "failLabelResult";
            this.failLabelResult.Size = new System.Drawing.Size(0, 13);
            this.failLabelResult.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Chat.log";
            this.openFileDialog1.Filter = "Chat Log Files|*.log";
            this.openFileDialog1.ReadOnlyChecked = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 112);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(382, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 43);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(99, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add to current";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // openTextInputerButton
            // 
            this.openTextInputerButton.Location = new System.Drawing.Point(374, 12);
            this.openTextInputerButton.Name = "openTextInputerButton";
            this.openTextInputerButton.Size = new System.Drawing.Size(20, 23);
            this.openTextInputerButton.TabIndex = 11;
            this.openTextInputerButton.Text = "?";
            this.openTextInputerButton.UseVisualStyleBackColor = true;
            this.openTextInputerButton.Click += new System.EventHandler(this.openTextInputerButton_Click);
            // 
            // ChatLogParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Enhancing_ChatLog_Parser.Properties.Resources.aionsc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(406, 147);
            this.Controls.Add(this.openTextInputerButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.failLabelResult);
            this.Controls.Add(this.successLabelResult);
            this.Controls.Add(this.totalLabelResult);
            this.Controls.Add(this.failLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.selectFileButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChatLogParser";
            this.Text = "ChatLogParser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label failLabel;
        private System.Windows.Forms.Label totalLabelResult;
        private System.Windows.Forms.Label successLabelResult;
        private System.Windows.Forms.Label failLabelResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button openTextInputerButton;
    }
}

