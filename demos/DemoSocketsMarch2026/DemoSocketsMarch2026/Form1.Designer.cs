namespace DemoSocketsMarch2026
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
            TB_Text = new TextBox();
            BTN_Connect = new Button();
            SuspendLayout();
            // 
            // TB_Text
            // 
            TB_Text.Location = new Point(266, 157);
            TB_Text.Name = "TB_Text";
            TB_Text.Size = new Size(163, 23);
            TB_Text.TabIndex = 0;
            // 
            // BTN_Connect
            // 
            BTN_Connect.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTN_Connect.Location = new Point(209, 186);
            BTN_Connect.Name = "BTN_Connect";
            BTN_Connect.Size = new Size(282, 130);
            BTN_Connect.TabIndex = 1;
            BTN_Connect.Text = "Connect";
            BTN_Connect.UseVisualStyleBackColor = true;
            BTN_Connect.Click += BTN_Connect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_Connect);
            Controls.Add(TB_Text);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Text;
        protected Button BTN_Connect;
    }
}
