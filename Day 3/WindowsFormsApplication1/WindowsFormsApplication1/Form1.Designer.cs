namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.DOBSelector = new System.Windows.Forms.DateTimePicker();
            this.requestGreeting = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOB";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(31, 172);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 13);
            this.message.TabIndex = 2;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.message.Click += new System.EventHandler(this.message_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(160, 31);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(112, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // DOBSelector
            // 
            this.DOBSelector.Location = new System.Drawing.Point(160, 65);
            this.DOBSelector.Name = "DOBSelector";
            this.DOBSelector.Size = new System.Drawing.Size(112, 20);
            this.DOBSelector.TabIndex = 4;
            // 
            // requestGreeting
            // 
            this.requestGreeting.Location = new System.Drawing.Point(160, 125);
            this.requestGreeting.Name = "requestGreeting";
            this.requestGreeting.Size = new System.Drawing.Size(112, 23);
            this.requestGreeting.TabIndex = 5;
            this.requestGreeting.Text = "Give Greeting";
            this.requestGreeting.UseVisualStyleBackColor = true;
            this.requestGreeting.Click += new System.EventHandler(this.requestGreeting_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(87, 213);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(112, 23);
            this.close.TabIndex = 6;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.close);
            this.Controls.Add(this.requestGreeting);
            this.Controls.Add(this.DOBSelector);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Birthday Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker DOBSelector;
        private System.Windows.Forms.Button requestGreeting;
        private System.Windows.Forms.Button close;
    }
}

