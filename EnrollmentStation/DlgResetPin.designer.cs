﻿namespace EnrollmentStation
{
    partial class DlgResetPin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPinNewAgain = new System.Windows.Forms.TextBox();
            this.txtPinNew = new System.Windows.Forms.TextBox();
            this.cmdChange = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSerialNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yubikey";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(116, 20);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(80, 13);
            this.lblSerialNumber.TabIndex = 1;
            this.lblSerialNumber.Text = "lblSerialNumber";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPinNewAgain);
            this.groupBox2.Controls.Add(this.txtPinNew);
            this.groupBox2.Location = new System.Drawing.Point(12, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PINs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repeat new PIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New PIN";
            // 
            // txtPinNewAgain
            // 
            this.txtPinNewAgain.Location = new System.Drawing.Point(116, 41);
            this.txtPinNewAgain.Name = "txtPinNewAgain";
            this.txtPinNewAgain.PasswordChar = '*';
            this.txtPinNewAgain.Size = new System.Drawing.Size(122, 20);
            this.txtPinNewAgain.TabIndex = 3;
            this.txtPinNewAgain.TextChanged += new System.EventHandler(this.textField_Changed);
            this.txtPinNewAgain.Validating += new System.ComponentModel.CancelEventHandler(this.txtPinNewAgain_Validating);
            // 
            // txtPinNew
            // 
            this.txtPinNew.Location = new System.Drawing.Point(116, 16);
            this.txtPinNew.Name = "txtPinNew";
            this.txtPinNew.PasswordChar = '*';
            this.txtPinNew.Size = new System.Drawing.Size(122, 20);
            this.txtPinNew.TabIndex = 1;
            this.txtPinNew.TextChanged += new System.EventHandler(this.textField_Changed);
            this.txtPinNew.Validating += new System.ComponentModel.CancelEventHandler(this.txtPinNew_Validating);
            // 
            // cmdChange
            // 
            this.cmdChange.Enabled = false;
            this.cmdChange.Location = new System.Drawing.Point(181, 138);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(75, 23);
            this.cmdChange.TabIndex = 2;
            this.cmdChange.Text = "Reset";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // DlgResetPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(266, 164);
            this.Controls.Add(this.cmdChange);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgResetPin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reset PIN code";
            this.Load += new System.EventHandler(this.DlgChangePin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPinNewAgain;
        private System.Windows.Forms.TextBox txtPinNew;
        private System.Windows.Forms.Button cmdChange;
        private System.Windows.Forms.Label label2;
    }
}