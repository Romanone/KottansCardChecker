namespace Bank
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblValid = new System.Windows.Forms.Label();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pbCheck = new System.Windows.Forms.PictureBox();
            this.pbVendor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCardNumber = new System.Windows.Forms.GroupBox();
            this.gbNextNumber = new System.Windows.Forms.GroupBox();
            this.btnGenerator = new System.Windows.Forms.Button();
            this.tbGenerator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGetCreditCardVendor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIsCreditCardNumberValid = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendor)).BeginInit();
            this.gbCardNumber.SuspendLayout();
            this.gbNextNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(6, 26);
            this.tbInput.MaxLength = 23;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(265, 27);
            this.tbInput.TabIndex = 0;
            this.tbInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInput_KeyPress);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(6, 59);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(265, 29);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Перевірити";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(6, 42);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(76, 19);
            this.lblVendor.TabIndex = 2;
            this.lblVendor.Text = "Unknown";
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(6, 94);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(76, 19);
            this.lblValid.TabIndex = 3;
            this.lblValid.Text = "Unknown";
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.btnClear);
            this.gbInformation.Controls.Add(this.btnAbout);
            this.gbInformation.Controls.Add(this.pbCheck);
            this.gbInformation.Controls.Add(this.pbVendor);
            this.gbInformation.Controls.Add(this.label2);
            this.gbInformation.Controls.Add(this.lblValid);
            this.gbInformation.Controls.Add(this.label1);
            this.gbInformation.Controls.Add(this.lblVendor);
            this.gbInformation.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbInformation.Location = new System.Drawing.Point(295, 12);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(192, 194);
            this.gbInformation.TabIndex = 4;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Інформація";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(6, 161);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(180, 27);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.Text = "Про...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pbCheck
            // 
            this.pbCheck.Location = new System.Drawing.Point(165, 75);
            this.pbCheck.Name = "pbCheck";
            this.pbCheck.Size = new System.Drawing.Size(21, 21);
            this.pbCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCheck.TabIndex = 5;
            this.pbCheck.TabStop = false;
            // 
            // pbVendor
            // 
            this.pbVendor.Image = global::Bank.Properties.Resources.kottans;
            this.pbVendor.Location = new System.Drawing.Point(128, 16);
            this.pbVendor.Name = "pbVendor";
            this.pbVendor.Size = new System.Drawing.Size(58, 37);
            this.pbVendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVendor.TabIndex = 4;
            this.pbVendor.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Валідність номера:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вендор картки:";
            // 
            // gbCardNumber
            // 
            this.gbCardNumber.Controls.Add(this.tbInput);
            this.gbCardNumber.Controls.Add(this.btnCheck);
            this.gbCardNumber.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCardNumber.Location = new System.Drawing.Point(12, 12);
            this.gbCardNumber.Name = "gbCardNumber";
            this.gbCardNumber.Size = new System.Drawing.Size(277, 94);
            this.gbCardNumber.TabIndex = 5;
            this.gbCardNumber.TabStop = false;
            this.gbCardNumber.Text = "Номер картки";
            // 
            // gbNextNumber
            // 
            this.gbNextNumber.Controls.Add(this.btnDel);
            this.gbNextNumber.Controls.Add(this.btnGenerator);
            this.gbNextNumber.Controls.Add(this.tbGenerator);
            this.gbNextNumber.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbNextNumber.Location = new System.Drawing.Point(12, 112);
            this.gbNextNumber.Name = "gbNextNumber";
            this.gbNextNumber.Size = new System.Drawing.Size(277, 94);
            this.gbNextNumber.TabIndex = 6;
            this.gbNextNumber.TabStop = false;
            this.gbNextNumber.Text = "Генератор валідних номерів";
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(6, 59);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(265, 29);
            this.btnGenerator.TabIndex = 2;
            this.btnGenerator.Text = "Згенерувати номер та перевірити";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // tbGenerator
            // 
            this.tbGenerator.Location = new System.Drawing.Point(6, 26);
            this.tbGenerator.Name = "tbGenerator";
            this.tbGenerator.ReadOnly = true;
            this.tbGenerator.Size = new System.Drawing.Size(265, 27);
            this.tbGenerator.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Credit Card Vendor:";
            // 
            // lblGetCreditCardVendor
            // 
            this.lblGetCreditCardVendor.AutoSize = true;
            this.lblGetCreditCardVendor.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGetCreditCardVendor.Location = new System.Drawing.Point(248, 209);
            this.lblGetCreditCardVendor.Name = "lblGetCreditCardVendor";
            this.lblGetCreditCardVendor.Size = new System.Drawing.Size(35, 19);
            this.lblGetCreditCardVendor.TabIndex = 8;
            this.lblGetCreditCardVendor.Text = "null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Credit Card Number Valid:";
            // 
            // lblIsCreditCardNumberValid
            // 
            this.lblIsCreditCardNumberValid.AutoSize = true;
            this.lblIsCreditCardNumberValid.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIsCreditCardNumberValid.Location = new System.Drawing.Point(248, 228);
            this.lblIsCreditCardNumberValid.Name = "lblIsCreditCardNumberValid";
            this.lblIsCreditCardNumberValid.Size = new System.Drawing.Size(35, 19);
            this.lblIsCreditCardNumberValid.TabIndex = 10;
            this.lblIsCreditCardNumberValid.Text = "null";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(240, 25);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(30, 28);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "X";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 261);
            this.Controls.Add(this.lblIsCreditCardNumberValid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGetCreditCardVendor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbNextNumber);
            this.Controls.Add(this.gbCardNumber);
            this.Controls.Add(this.gbInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Checker";
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVendor)).EndInit();
            this.gbCardNumber.ResumeLayout(false);
            this.gbCardNumber.PerformLayout();
            this.gbNextNumber.ResumeLayout(false);
            this.gbNextNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCardNumber;
        private System.Windows.Forms.GroupBox gbNextNumber;
        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.TextBox tbGenerator;
        private System.Windows.Forms.PictureBox pbVendor;
        private System.Windows.Forms.PictureBox pbCheck;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGetCreditCardVendor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIsCreditCardNumberValid;
        private System.Windows.Forms.Button btnDel;
    }
}

