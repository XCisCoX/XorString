namespace XorString
{
    partial class frmMain
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.txtGenerated = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCopyWithCode = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(570, 250);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(9, 59);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(633, 78);
            this.txtMain.TabIndex = 1;
            // 
            // txtGenerated
            // 
            this.txtGenerated.Location = new System.Drawing.Point(12, 162);
            this.txtGenerated.Multiline = true;
            this.txtGenerated.Name = "txtGenerated";
            this.txtGenerated.ReadOnly = true;
            this.txtGenerated.Size = new System.Drawing.Size(633, 78);
            this.txtGenerated.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Your Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Generated Text:";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(489, 250);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(587, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 24);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopyWithCode
            // 
            this.btnCopyWithCode.Location = new System.Drawing.Point(368, 250);
            this.btnCopyWithCode.Name = "btnCopyWithCode";
            this.btnCopyWithCode.Size = new System.Drawing.Size(115, 23);
            this.btnCopyWithCode.TabIndex = 6;
            this.btnCopyWithCode.Text = "Copy With Code";
            this.btnCopyWithCode.UseVisualStyleBackColor = true;
            this.btnCopyWithCode.Click += new System.EventHandler(this.btnCopyWithCode_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(9, 262);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(278, 12);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(205, 23);
            this.txtKey.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Key:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 297);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnCopyWithCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGenerated);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Xor String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerate;
        private TextBox txtMain;
        private TextBox txtGenerated;
        private Label label1;
        private Label label2;
        private Button btnCopy;
        private Button btnClear;
        private Button btnCopyWithCode;
        private Button btnAbout;
        private TextBox txtKey;
        private Label label3;
    }
}