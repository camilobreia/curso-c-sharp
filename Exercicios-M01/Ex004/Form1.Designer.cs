namespace Ex004
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
            label1 = new Label();
            txtNum = new TextBox();
            btnOk = new Button();
            panResultado = new Panel();
            lblMsg3 = new Label();
            lblMsg2 = new Label();
            lblMsg1 = new Label();
            panResultado.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(18, 51);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "Digite um número Real:";
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI", 14F);
            txtNum.Location = new Point(231, 51);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(70, 32);
            txtNum.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 14F);
            btnOk.Location = new Point(101, 96);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(93, 34);
            btnOk.TabIndex = 2;
            btnOk.Text = " OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // panResultado
            // 
            panResultado.Controls.Add(lblMsg3);
            panResultado.Controls.Add(lblMsg2);
            panResultado.Controls.Add(lblMsg1);
            panResultado.Location = new Point(26, 136);
            panResultado.Name = "panResultado";
            panResultado.Size = new Size(275, 142);
            panResultado.TabIndex = 3;
            panResultado.Visible = false;
            // 
            // lblMsg3
            // 
            lblMsg3.AutoSize = true;
            lblMsg3.Font = new Font("Segoe UI", 14F);
            lblMsg3.Location = new Point(12, 94);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(63, 25);
            lblMsg3.TabIndex = 2;
            lblMsg3.Text = "label4";
            lblMsg3.Click += label4_Click;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Font = new Font("Segoe UI", 14F);
            lblMsg2.Location = new Point(12, 60);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(63, 25);
            lblMsg2.TabIndex = 1;
            lblMsg2.Text = "label3";
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Font = new Font("Segoe UI", 14F);
            lblMsg1.Location = new Point(12, 24);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(63, 25);
            lblMsg1.TabIndex = 0;
            lblMsg1.Text = "label2";
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 308);
            Controls.Add(panResultado);
            Controls.Add(btnOk);
            Controls.Add(txtNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panResultado.ResumeLayout(false);
            panResultado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnOk;
        private Panel panResultado;
        private Label lblMsg3;
        private Label lblMsg2;
        private Label lblMsg1;
    }
}
