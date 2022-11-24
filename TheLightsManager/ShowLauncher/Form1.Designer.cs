namespace ShowLauncher
{
    partial class LaunchController
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
            this.BtnStartShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStartShow
            // 
            this.BtnStartShow.Location = new System.Drawing.Point(593, 922);
            this.BtnStartShow.Name = "BtnStartShow";
            this.BtnStartShow.Size = new System.Drawing.Size(112, 34);
            this.BtnStartShow.TabIndex = 0;
            this.BtnStartShow.Text = "Start Show";
            this.BtnStartShow.UseVisualStyleBackColor = true;
            this.BtnStartShow.Click += new System.EventHandler(this.BtnStartShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 968);
            this.Controls.Add(this.BtnStartShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnStartShow;
    }
}