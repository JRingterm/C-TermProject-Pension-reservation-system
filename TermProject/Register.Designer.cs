namespace TermProject
{
    partial class Register
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
            this.Idregister_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwregister_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnregister_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnregister_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnregister_textbox2 = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Idregister_textbox
            // 
            this.Idregister_textbox.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Idregister_textbox.Location = new System.Drawing.Point(141, 67);
            this.Idregister_textbox.Name = "Idregister_textbox";
            this.Idregister_textbox.Size = new System.Drawing.Size(251, 25);
            this.Idregister_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(50, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(50, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "비밀번호";
            // 
            // pwregister_textbox
            // 
            this.pwregister_textbox.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwregister_textbox.Location = new System.Drawing.Point(141, 113);
            this.pwregister_textbox.Name = "pwregister_textbox";
            this.pwregister_textbox.PasswordChar = '*';
            this.pwregister_textbox.Size = new System.Drawing.Size(251, 25);
            this.pwregister_textbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(50, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "전화번호";
            // 
            // pnregister_textbox
            // 
            this.pnregister_textbox.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnregister_textbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pnregister_textbox.Location = new System.Drawing.Point(236, 163);
            this.pnregister_textbox.Name = "pnregister_textbox";
            this.pnregister_textbox.Size = new System.Drawing.Size(68, 25);
            this.pnregister_textbox.TabIndex = 5;
            this.pnregister_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pnregister_textbox_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(66, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "회원가입하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnregister_combobox
            // 
            this.pnregister_combobox.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnregister_combobox.FormattingEnabled = true;
            this.pnregister_combobox.Items.AddRange(new object[] {
            "010",
            "02",
            "051",
            "053",
            "032",
            "062",
            "042",
            "044",
            "031",
            "033",
            "043",
            "041",
            "063",
            "054",
            "055",
            "052",
            "061",
            "064"});
            this.pnregister_combobox.Location = new System.Drawing.Point(141, 163);
            this.pnregister_combobox.Name = "pnregister_combobox";
            this.pnregister_combobox.Size = new System.Drawing.Size(73, 26);
            this.pnregister_combobox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(219, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(308, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "-";
            // 
            // pnregister_textbox2
            // 
            this.pnregister_textbox2.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnregister_textbox2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.pnregister_textbox2.Location = new System.Drawing.Point(324, 163);
            this.pnregister_textbox2.Name = "pnregister_textbox2";
            this.pnregister_textbox2.Size = new System.Drawing.Size(68, 25);
            this.pnregister_textbox2.TabIndex = 12;
            this.pnregister_textbox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pnregister_textbox2_KeyPress);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_button.Font = new System.Drawing.Font("문체부 돋음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel_button.Location = new System.Drawing.Point(275, 224);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(117, 49);
            this.cancel_button.TabIndex = 23;
            this.cancel_button.Text = "취소";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 310);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.pnregister_textbox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnregister_combobox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnregister_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pwregister_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Idregister_textbox);
            this.Name = "Register";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Idregister_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pwregister_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pnregister_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox pnregister_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pnregister_textbox2;
        private System.Windows.Forms.Button cancel_button;
    }
}