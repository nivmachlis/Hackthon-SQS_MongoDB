namespace HacktonSQS
{
    partial class FormConsumer
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
            this.buttonConsumeMessage = new System.Windows.Forms.Button();
            this.labelQueueMessages = new System.Windows.Forms.Label();
            this.labelNumOfMessages = new System.Windows.Forms.Label();
            this.buttonRefreshMessagesAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonConsumeMessage
            // 
            this.buttonConsumeMessage.Location = new System.Drawing.Point(333, 56);
            this.buttonConsumeMessage.Name = "buttonConsumeMessage";
            this.buttonConsumeMessage.Size = new System.Drawing.Size(415, 201);
            this.buttonConsumeMessage.TabIndex = 0;
            this.buttonConsumeMessage.Text = "Consume Message";
            this.buttonConsumeMessage.UseVisualStyleBackColor = true;
            this.buttonConsumeMessage.Click += new System.EventHandler(this.buttonConsumeMessage_Click);
            // 
            // labelQueueMessages
            // 
            this.labelQueueMessages.AutoSize = true;
            this.labelQueueMessages.Location = new System.Drawing.Point(29, 77);
            this.labelQueueMessages.Name = "labelQueueMessages";
            this.labelQueueMessages.Size = new System.Drawing.Size(151, 20);
            this.labelQueueMessages.TabIndex = 2;
            this.labelQueueMessages.Text = "Messages in queue:";
            // 
            // labelNumOfMessages
            // 
            this.labelNumOfMessages.AutoSize = true;
            this.labelNumOfMessages.Location = new System.Drawing.Point(218, 77);
            this.labelNumOfMessages.Name = "labelNumOfMessages";
            this.labelNumOfMessages.Size = new System.Drawing.Size(21, 20);
            this.labelNumOfMessages.TabIndex = 3;
            this.labelNumOfMessages.Text = "...";
            // 
            // buttonRefreshMessagesAmount
            // 
            this.buttonRefreshMessagesAmount.Location = new System.Drawing.Point(33, 119);
            this.buttonRefreshMessagesAmount.Name = "buttonRefreshMessagesAmount";
            this.buttonRefreshMessagesAmount.Size = new System.Drawing.Size(206, 75);
            this.buttonRefreshMessagesAmount.TabIndex = 4;
            this.buttonRefreshMessagesAmount.Text = "Refresh amount of messages";
            this.buttonRefreshMessagesAmount.UseVisualStyleBackColor = true;
            this.buttonRefreshMessagesAmount.Click += new System.EventHandler(this.buttonRefreshMessagesAmount_Click);
            // 
            // FormConsumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefreshMessagesAmount);
            this.Controls.Add(this.labelNumOfMessages);
            this.Controls.Add(this.labelQueueMessages);
            this.Controls.Add(this.buttonConsumeMessage);
            this.Name = "FormConsumer";
            this.Text = "Consumer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConsumeMessage;
        private System.Windows.Forms.Label labelQueueMessages;
        private System.Windows.Forms.Label labelNumOfMessages;
        private System.Windows.Forms.Button buttonRefreshMessagesAmount;
    }
}

