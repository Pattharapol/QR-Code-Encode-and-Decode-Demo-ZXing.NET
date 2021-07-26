
namespace QR_Code_Demo_ZXing.NET
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
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSaveQR = new System.Windows.Forms.Button();
            this.btnLoadQR = new System.Windows.Forms.Button();
            this.btnCOPY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(48, 68);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(397, 29);
            this.txtEncode.TabIndex = 0;
            this.txtEncode.TextChanged += new System.EventHandler(this.txtEncode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to Encode : ";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(48, 103);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(397, 301);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // btnSaveQR
            // 
            this.btnSaveQR.Location = new System.Drawing.Point(48, 419);
            this.btnSaveQR.Name = "btnSaveQR";
            this.btnSaveQR.Size = new System.Drawing.Size(397, 36);
            this.btnSaveQR.TabIndex = 3;
            this.btnSaveQR.Text = "Save QR Code";
            this.btnSaveQR.UseVisualStyleBackColor = true;
            this.btnSaveQR.Click += new System.EventHandler(this.btnSaveQR_Click);
            // 
            // btnLoadQR
            // 
            this.btnLoadQR.Location = new System.Drawing.Point(48, 461);
            this.btnLoadQR.Name = "btnLoadQR";
            this.btnLoadQR.Size = new System.Drawing.Size(397, 36);
            this.btnLoadQR.TabIndex = 3;
            this.btnLoadQR.Text = "Load QR Code";
            this.btnLoadQR.UseVisualStyleBackColor = true;
            this.btnLoadQR.Click += new System.EventHandler(this.btnLoadQR_Click);
            // 
            // btnCOPY
            // 
            this.btnCOPY.Location = new System.Drawing.Point(48, 503);
            this.btnCOPY.Name = "btnCOPY";
            this.btnCOPY.Size = new System.Drawing.Size(397, 36);
            this.btnCOPY.TabIndex = 3;
            this.btnCOPY.Text = "Copy to clipboard";
            this.btnCOPY.UseVisualStyleBackColor = true;
            this.btnCOPY.Click += new System.EventHandler(this.btnCOPY_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(494, 597);
            this.Controls.Add(this.btnCOPY);
            this.Controls.Add(this.btnLoadQR);
            this.Controls.Add(this.btnSaveQR);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncode);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code with ZXing.NET";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSaveQR;
        private System.Windows.Forms.Button btnLoadQR;
        private System.Windows.Forms.Button btnCOPY;
    }
}

