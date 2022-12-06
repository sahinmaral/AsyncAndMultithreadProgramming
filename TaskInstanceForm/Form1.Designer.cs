namespace TaskInstanceForm
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
            this.btnStartGetStringAsync = new System.Windows.Forms.Button();
            this.rchTxtGoogleString = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnStartGetStringAsync
            // 
            this.btnStartGetStringAsync.Location = new System.Drawing.Point(15, 18);
            this.btnStartGetStringAsync.Name = "btnStartGetStringAsync";
            this.btnStartGetStringAsync.Size = new System.Drawing.Size(210, 44);
            this.btnStartGetStringAsync.TabIndex = 0;
            this.btnStartGetStringAsync.Text = "Get google as string";
            this.btnStartGetStringAsync.UseVisualStyleBackColor = true;
            this.btnStartGetStringAsync.Click += new System.EventHandler(this.btnStartGetStringAsync_Click);
            // 
            // rchTxtGoogleString
            // 
            this.rchTxtGoogleString.Location = new System.Drawing.Point(16, 74);
            this.rchTxtGoogleString.Name = "rchTxtGoogleString";
            this.rchTxtGoogleString.Size = new System.Drawing.Size(209, 364);
            this.rchTxtGoogleString.TabIndex = 1;
            this.rchTxtGoogleString.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 450);
            this.Controls.Add(this.rchTxtGoogleString);
            this.Controls.Add(this.btnStartGetStringAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStartGetStringAsync;
        private RichTextBox rchTxtGoogleString;
    }
}