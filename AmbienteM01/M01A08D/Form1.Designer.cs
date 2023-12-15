namespace M01A08D
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
            lblMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 43);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite um número:";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(144, 40);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(67, 23);
            txtNum.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(144, 79);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(67, 23);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += button1_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(31, 130);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(66, 15);
            lblMsg.TabIndex = 3;
            lblMsg.Text = "Mensagem";
            lblMsg.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 184);
            Controls.Add(lblMsg);
            Controls.Add(btnOk);
            Controls.Add(txtNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnOk;
        private Label lblMsg;
    }
}
