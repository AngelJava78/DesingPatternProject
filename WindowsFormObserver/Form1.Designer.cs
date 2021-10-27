
namespace WindowsFormObserver
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.subscriberListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.messagesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products";
            // 
            // productListBox
            // 
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 20;
            this.productListBox.Location = new System.Drawing.Point(13, 36);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(200, 404);
            this.productListBox.TabIndex = 1;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            this.productListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productListBox_MouseDoubleClick);
            // 
            // subscriberListBox
            // 
            this.subscriberListBox.FormattingEnabled = true;
            this.subscriberListBox.ItemHeight = 20;
            this.subscriberListBox.Location = new System.Drawing.Point(220, 36);
            this.subscriberListBox.Name = "subscriberListBox";
            this.subscriberListBox.Size = new System.Drawing.Size(200, 404);
            this.subscriberListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subscribers";
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.ItemHeight = 20;
            this.userListBox.Location = new System.Drawing.Point(430, 36);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(200, 404);
            this.userListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Users";
            // 
            // subscribeButton
            // 
            this.subscribeButton.Location = new System.Drawing.Point(636, 409);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(101, 29);
            this.subscribeButton.TabIndex = 6;
            this.subscribeButton.Text = "Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Location = new System.Drawing.Point(743, 409);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(101, 29);
            this.unsubscribeButton.TabIndex = 7;
            this.unsubscribeButton.Text = "Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Location = new System.Drawing.Point(637, 36);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.Size = new System.Drawing.Size(353, 367);
            this.messagesTextBox.TabIndex = 8;
            // 
            // messagesLabel
            // 
            this.messagesLabel.AutoSize = true;
            this.messagesLabel.Location = new System.Drawing.Point(637, 13);
            this.messagesLabel.Name = "messagesLabel";
            this.messagesLabel.Size = new System.Drawing.Size(44, 20);
            this.messagesLabel.TabIndex = 9;
            this.messagesLabel.Text = "Users";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.messagesLabel);
            this.Controls.Add(this.messagesTextBox);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subscriberListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.ListBox subscriberListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button subscribeButton;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.Label messagesLabel;
    }
}

