﻿namespace Demo3Layer.GUI
{
    partial class frmSendMail
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            btnSend = new Button();
            htmlEditControl1 = new Zoople.HTMLEditControl();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(115, 50);
            label1.TabIndex = 0;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 105);
            label2.Name = "label2";
            label2.Size = new Size(67, 50);
            label2.TabIndex = 1;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 178);
            label3.Name = "label3";
            label3.Size = new Size(151, 50);
            label3.TabIndex = 0;
            label3.Text = "Subject:";
            // 
            // txtFrom
            // 
            txtFrom.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFrom.Location = new Point(227, 32);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(870, 57);
            txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            txtTo.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTo.Location = new Point(227, 105);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(870, 57);
            txtTo.TabIndex = 3;
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubject.Location = new Point(227, 178);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(870, 57);
            txtSubject.TabIndex = 4;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(835, 630);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(262, 75);
            btnSend.TabIndex = 6;
            btnSend.Text = "Gửi";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // htmlEditControl1
            // 
            htmlEditControl1.AcceptsReturn = true;
            htmlEditControl1.BaseURL = null;
            htmlEditControl1.CleanMSWordHTMLOnPaste = true;
            htmlEditControl1.CSSText = null;
            htmlEditControl1.DocumentHTML = null;
            htmlEditControl1.EnableInlineSpelling = false;
            htmlEditControl1.FontSizesList = null;
            htmlEditControl1.FontsList = null;
            htmlEditControl1.HiddenButtons = null;
            htmlEditControl1.ImageStorageLocation = null;
            htmlEditControl1.InCodeView = false;
            htmlEditControl1.IndentAmount = 2;
            htmlEditControl1.IndentsUseBlockuote = false;
            htmlEditControl1.LanguageFile = null;
            htmlEditControl1.LicenceActivationKey = null;
            htmlEditControl1.LicenceKey = null;
            htmlEditControl1.LicenceKeyInlineSpelling = null;
            htmlEditControl1.Location = new Point(68, 262);
            htmlEditControl1.Name = "htmlEditControl1";
            htmlEditControl1.Size = new Size(1029, 344);
            htmlEditControl1.TabIndex = 7;
            htmlEditControl1.ToolstripImageScalingSize = new Size(32, 32);
            htmlEditControl1.UseParagraphAsDefault = true;
            // 
            // frmSendMail
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 729);
            Controls.Add(htmlEditControl1);
            Controls.Add(btnSend);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSendMail";
            Text = "Gửi mail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtSubject;
        private Button btnSend;
        private Zoople.HTMLEditControl htmlEditControl1;
    }
}