﻿namespace WindowsEx000
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
            btn = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btn
            // 
            btn.Font = new Font("Segoe UI", 12F);
            btn.Location = new Point(280, 281);
            btn.Name = "btn";
            btn.Size = new Size(224, 92);
            btn.TabIndex = 0;
            btn.Text = "Clique em Mim!";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // lblMsg
            // 
            lblMsg.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMsg.Location = new Point(12, 57);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(776, 51);
            lblMsg.TabIndex = 1;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMsg);
            Controls.Add(btn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Primeiro Programa C#";
            ResumeLayout(false);
        }

        #endregion

        private Button btn;
        private Label lblMsg;
    }
}
