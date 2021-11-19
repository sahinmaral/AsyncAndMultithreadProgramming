
namespace BeginningToAsyncProgramming
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
            this.rchTxtName = new System.Windows.Forms.RichTextBox();
            this.rchTxtGoogle = new System.Windows.Forms.RichTextBox();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnAddCounter = new System.Windows.Forms.Button();
            this.lblCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchTxtName
            // 
            this.rchTxtName.Location = new System.Drawing.Point(12, 59);
            this.rchTxtName.Name = "rchTxtName";
            this.rchTxtName.Size = new System.Drawing.Size(184, 302);
            this.rchTxtName.TabIndex = 0;
            this.rchTxtName.Text = "";
            // 
            // rchTxtGoogle
            // 
            this.rchTxtGoogle.Location = new System.Drawing.Point(471, 59);
            this.rchTxtGoogle.Name = "rchTxtGoogle";
            this.rchTxtGoogle.Size = new System.Drawing.Size(199, 302);
            this.rchTxtGoogle.TabIndex = 1;
            this.rchTxtGoogle.Text = "";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(13, 13);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(183, 31);
            this.btnReadFile.TabIndex = 2;
            this.btnReadFile.Text = "Dosya Oku";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnAddCounter
            // 
            this.btnAddCounter.Location = new System.Drawing.Point(202, 134);
            this.btnAddCounter.Name = "btnAddCounter";
            this.btnAddCounter.Size = new System.Drawing.Size(263, 31);
            this.btnAddCounter.TabIndex = 3;
            this.btnAddCounter.Text = "Arttır";
            this.btnAddCounter.UseVisualStyleBackColor = true;
            this.btnAddCounter.Click += new System.EventHandler(this.btnAddCounter_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCounter.Location = new System.Drawing.Point(310, 86);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(45, 28);
            this.lblCounter.TabIndex = 4;
            this.lblCounter.Text = "000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 378);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.btnAddCounter);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.rchTxtGoogle);
            this.Controls.Add(this.rchTxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtName;
        private System.Windows.Forms.RichTextBox rchTxtGoogle;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnAddCounter;
        private System.Windows.Forms.Label lblCounter;
    }
}

