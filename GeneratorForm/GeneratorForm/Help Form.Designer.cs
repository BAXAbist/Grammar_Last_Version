namespace GeneratorForm
{
    partial class Help_Form
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
            this.Help_RichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Help_RichTextBox
            // 
            this.Help_RichTextBox.Location = new System.Drawing.Point(12, 12);
            this.Help_RichTextBox.Name = "Help_RichTextBox";
            this.Help_RichTextBox.ReadOnly = true;
            this.Help_RichTextBox.Size = new System.Drawing.Size(559, 446);
            this.Help_RichTextBox.TabIndex = 0;
            this.Help_RichTextBox.Text = "";
            // 
            // Help_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 470);
            this.Controls.Add(this.Help_RichTextBox);
            this.Name = "Help_Form";
            this.Text = "Help_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Help_RichTextBox;
    }
}