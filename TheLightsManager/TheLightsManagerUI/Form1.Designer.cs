namespace TheLightsManagerUI
{
    partial class LightMgr
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
            this.TbRed = new System.Windows.Forms.TextBox();
            this.TbGreen = new System.Windows.Forms.TextBox();
            this.TbBlue = new System.Windows.Forms.TextBox();
            this.lbRed = new System.Windows.Forms.Label();
            this.LbGreen = new System.Windows.Forms.Label();
            this.LbBlue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.CbAddressingMode = new System.Windows.Forms.ComboBox();
            this.lbAddressingType = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LbTo = new System.Windows.Forms.Label();
            this.lbOr = new System.Windows.Forms.Label();
            this.LbDelay = new System.Windows.Forms.Label();
            this.tbDelay = new System.Windows.Forms.TextBox();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLicenses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbRed
            // 
            this.TbRed.Location = new System.Drawing.Point(363, 293);
            this.TbRed.Name = "TbRed";
            this.TbRed.Size = new System.Drawing.Size(150, 31);
            this.TbRed.TabIndex = 0;
            // 
            // TbGreen
            // 
            this.TbGreen.Location = new System.Drawing.Point(583, 293);
            this.TbGreen.Name = "TbGreen";
            this.TbGreen.Size = new System.Drawing.Size(150, 31);
            this.TbGreen.TabIndex = 1;
            // 
            // TbBlue
            // 
            this.TbBlue.Location = new System.Drawing.Point(796, 293);
            this.TbBlue.Name = "TbBlue";
            this.TbBlue.Size = new System.Drawing.Size(150, 31);
            this.TbBlue.TabIndex = 2;
            // 
            // lbRed
            // 
            this.lbRed.AutoSize = true;
            this.lbRed.Location = new System.Drawing.Point(298, 296);
            this.lbRed.Name = "lbRed";
            this.lbRed.Size = new System.Drawing.Size(42, 25);
            this.lbRed.TabIndex = 3;
            this.lbRed.Text = "Red";
            // 
            // LbGreen
            // 
            this.LbGreen.AutoSize = true;
            this.LbGreen.Location = new System.Drawing.Point(519, 296);
            this.LbGreen.Name = "LbGreen";
            this.LbGreen.Size = new System.Drawing.Size(58, 25);
            this.LbGreen.TabIndex = 4;
            this.LbGreen.Text = "Green";
            // 
            // LbBlue
            // 
            this.LbBlue.AutoSize = true;
            this.LbBlue.Location = new System.Drawing.Point(745, 296);
            this.LbBlue.Name = "LbBlue";
            this.LbBlue.Size = new System.Drawing.Size(45, 25);
            this.LbBlue.TabIndex = 5;
            this.LbBlue.Text = "Blue";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(363, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 6;
            // 
            // lbBrightness
            // 
            this.lbBrightness.AutoSize = true;
            this.lbBrightness.Location = new System.Drawing.Point(204, 368);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(136, 25);
            this.lbBrightness.TabIndex = 7;
            this.lbBrightness.Text = "Brightness (0-1)";
            // 
            // CbAddressingMode
            // 
            this.CbAddressingMode.FormattingEnabled = true;
            this.CbAddressingMode.Items.AddRange(new object[] {
            "Single Cell",
            "Range",
            "Nth Cells"});
            this.CbAddressingMode.Location = new System.Drawing.Point(363, 455);
            this.CbAddressingMode.Name = "CbAddressingMode";
            this.CbAddressingMode.Size = new System.Drawing.Size(150, 33);
            this.CbAddressingMode.TabIndex = 8;
            // 
            // lbAddressingType
            // 
            this.lbAddressingType.AutoSize = true;
            this.lbAddressingType.Location = new System.Drawing.Point(186, 458);
            this.lbAddressingType.Name = "lbAddressingType";
            this.lbAddressingType.Size = new System.Drawing.Size(154, 25);
            this.lbAddressingType.TabIndex = 9;
            this.lbAddressingType.Text = "Addressing Mode";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(583, 455);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(796, 455);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 11;
            // 
            // LbTo
            // 
            this.LbTo.AutoSize = true;
            this.LbTo.Location = new System.Drawing.Point(749, 458);
            this.LbTo.Name = "LbTo";
            this.LbTo.Size = new System.Drawing.Size(30, 25);
            this.LbTo.TabIndex = 12;
            this.LbTo.Text = "To";
            // 
            // lbOr
            // 
            this.lbOr.AutoSize = true;
            this.lbOr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbOr.Location = new System.Drawing.Point(583, 567);
            this.lbOr.Name = "lbOr";
            this.lbOr.Size = new System.Drawing.Size(48, 32);
            this.lbOr.TabIndex = 13;
            this.lbOr.Text = "OR";
            // 
            // LbDelay
            // 
            this.LbDelay.AutoSize = true;
            this.LbDelay.Location = new System.Drawing.Point(226, 680);
            this.LbDelay.Name = "LbDelay";
            this.LbDelay.Size = new System.Drawing.Size(114, 25);
            this.LbDelay.TabIndex = 15;
            this.LbDelay.Text = "Delay (in ms)";
            // 
            // tbDelay
            // 
            this.tbDelay.Location = new System.Drawing.Point(349, 677);
            this.tbDelay.Name = "tbDelay";
            this.tbDelay.Size = new System.Drawing.Size(150, 31);
            this.tbDelay.TabIndex = 14;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(375, 825);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(112, 34);
            this.BtnPrevious.TabIndex = 16;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Green;
            this.BtnAdd.Location = new System.Drawing.Point(519, 825);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(112, 34);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.BtnDelete.Location = new System.Drawing.Point(646, 825);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(112, 34);
            this.BtnDelete.TabIndex = 18;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(796, 825);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(112, 34);
            this.BtnNext.TabIndex = 19;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // BtnLicenses
            // 
            this.BtnLicenses.Location = new System.Drawing.Point(25, 920);
            this.BtnLicenses.Name = "BtnLicenses";
            this.BtnLicenses.Size = new System.Drawing.Size(112, 34);
            this.BtnLicenses.TabIndex = 20;
            this.BtnLicenses.Text = "License";
            this.BtnLicenses.UseVisualStyleBackColor = true;
            this.BtnLicenses.Click += new System.EventHandler(this.BtnLicenses_Click);
            // 
            // LightMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 968);
            this.Controls.Add(this.BtnLicenses);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.LbDelay);
            this.Controls.Add(this.tbDelay);
            this.Controls.Add(this.lbOr);
            this.Controls.Add(this.LbTo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbAddressingType);
            this.Controls.Add(this.CbAddressingMode);
            this.Controls.Add(this.lbBrightness);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LbBlue);
            this.Controls.Add(this.LbGreen);
            this.Controls.Add(this.lbRed);
            this.Controls.Add(this.TbBlue);
            this.Controls.Add(this.TbGreen);
            this.Controls.Add(this.TbRed);
            this.Name = "LightMgr";
            this.Text = "LightMgr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbRed;
        private TextBox TbGreen;
        private TextBox TbBlue;
        private Label lbRed;
        private Label LbGreen;
        private Label LbBlue;
        private TextBox textBox1;
        private Label lbBrightness;
        private ComboBox CbAddressingMode;
        private Label lbAddressingType;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label LbTo;
        private Label lbOr;
        private Label LbDelay;
        private TextBox tbDelay;
        private Button BtnPrevious;
        private Button BtnAdd;
        private Button BtnDelete;
        private Button BtnNext;
        private Button BtnLicenses;
    }
}