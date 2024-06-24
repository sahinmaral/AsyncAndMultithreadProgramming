namespace ParallelForCancellationToken
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
            listBoxContents = new ListBox();
            buttonShow = new Button();
            buttonIncrease = new Button();
            buttonDiscard = new Button();
            SuspendLayout();
            // 
            // listBoxContents
            // 
            listBoxContents.FormattingEnabled = true;
            listBoxContents.ItemHeight = 15;
            listBoxContents.Location = new Point(12, 41);
            listBoxContents.Name = "listBoxContents";
            listBoxContents.Size = new Size(414, 364);
            listBoxContents.TabIndex = 0;
            // 
            // buttonShow
            // 
            buttonShow.Location = new Point(12, 12);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(75, 23);
            buttonShow.TabIndex = 1;
            buttonShow.Text = "Getir";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonIncrease
            // 
            buttonIncrease.Location = new Point(174, 12);
            buttonIncrease.Name = "buttonIncrease";
            buttonIncrease.Size = new Size(75, 23);
            buttonIncrease.TabIndex = 2;
            buttonIncrease.Text = "0";
            buttonIncrease.UseVisualStyleBackColor = true;
            buttonIncrease.Click += buttonIncrease_Click;
            // 
            // buttonDiscard
            // 
            buttonDiscard.Location = new Point(93, 12);
            buttonDiscard.Name = "buttonDiscard";
            buttonDiscard.Size = new Size(75, 23);
            buttonDiscard.TabIndex = 3;
            buttonDiscard.Text = "Iptal";
            buttonDiscard.UseVisualStyleBackColor = true;
            buttonDiscard.Click += buttonDiscard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 416);
            Controls.Add(buttonDiscard);
            Controls.Add(buttonIncrease);
            Controls.Add(buttonShow);
            Controls.Add(listBoxContents);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxContents;
        private Button buttonShow;
        private Button buttonIncrease;
        private Button buttonDiscard;
    }
}
