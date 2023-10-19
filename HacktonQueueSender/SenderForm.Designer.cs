namespace HacktonSQS
{
    partial class SenderForm
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
            this.buttonSendEventMessages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSendEventMessages
            // 
            this.buttonSendEventMessages.Location = new System.Drawing.Point(253, 47);
            this.buttonSendEventMessages.Name = "buttonSendEventMessages";
            this.buttonSendEventMessages.Size = new System.Drawing.Size(264, 334);
            this.buttonSendEventMessages.TabIndex = 0;
            this.buttonSendEventMessages.Text = "Send Event Messages";
            this.buttonSendEventMessages.UseVisualStyleBackColor = true;
            this.buttonSendEventMessages.Click += new System.EventHandler(this.buttonSendEventMessages_Click);
            // 
            // SenderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSendEventMessages);
            this.Name = "SenderForm";
            this.Text = "SenderForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSendEventMessages;
    }
}

