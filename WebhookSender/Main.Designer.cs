
namespace WebhookSender
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.profileBox = new System.Windows.Forms.TextBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Webhook URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Webhook Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Webhook Profile URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Webhook Message";
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(15, 28);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(589, 21);
            this.urlBox.TabIndex = 5;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(15, 115);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(589, 21);
            this.nameBox.TabIndex = 6;
            // 
            // profileBox
            // 
            this.profileBox.Location = new System.Drawing.Point(15, 70);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(589, 21);
            this.profileBox.TabIndex = 7;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(15, 157);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(589, 69);
            this.messageBox.TabIndex = 8;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(15, 233);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(589, 29);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 270);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox profileBox;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendButton;
    }
}