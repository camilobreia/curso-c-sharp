namespace Ex002
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
            lblMsg1 = new Label();
            lblMsg2 = new Label();
            lblMsg3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Font = new Font("Segoe UI", 12F);
            lblMsg1.Location = new Point(24, 48);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(43, 21);
            lblMsg1.TabIndex = 0;
            lblMsg1.Text = "MEU";
            lblMsg1.Visible = false;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Font = new Font("Segoe UI", 12F);
            lblMsg2.Location = new Point(86, 48);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(60, 21);
            lblMsg2.TabIndex = 1;
            lblMsg2.Text = "BRASIL";
            lblMsg2.Visible = false;
            // 
            // lblMsg3
            // 
            lblMsg3.AutoSize = true;
            lblMsg3.Font = new Font("Segoe UI", 12F);
            lblMsg3.Location = new Point(160, 48);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(94, 21);
            lblMsg3.TabIndex = 2;
            lblMsg3.Text = "BRASILEIRO";
            lblMsg3.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(67, 103);
            button1.Name = "button1";
            button1.Size = new Size(111, 44);
            button1.TabIndex = 3;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 177);
            Controls.Add(button1);
            Controls.Add(lblMsg3);
            Controls.Add(lblMsg2);
            Controls.Add(lblMsg1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brasil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg1;
        private Label lblMsg2;
        private Label lblMsg3;
        private Button button1;
    }
}
