namespace TermProject
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.ID_textBox1 = new System.Windows.Forms.TextBox();
            this.PW_textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Area_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Theme_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Area_label = new System.Windows.Forms.Label();
            this.Book_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.Theme_label = new System.Windows.Forms.Label();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.nofilter_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logout_button = new System.Windows.Forms.Button();
            this.Booklist_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Login_btn.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Login_btn.Location = new System.Drawing.Point(633, 10);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(89, 32);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "로그인";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Register_btn.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Register_btn.Location = new System.Drawing.Point(728, 10);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(98, 32);
            this.Register_btn.TabIndex = 1;
            this.Register_btn.Text = "회원가입";
            this.Register_btn.UseVisualStyleBackColor = false;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_label.Location = new System.Drawing.Point(266, 17);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(59, 17);
            this.id_label.TabIndex = 2;
            this.id_label.Text = "아이디:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.password_label.Location = new System.Drawing.Point(435, 16);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(84, 17);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "비밀번호: ";
            // 
            // ID_textBox1
            // 
            this.ID_textBox1.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ID_textBox1.Location = new System.Drawing.Point(329, 12);
            this.ID_textBox1.Name = "ID_textBox1";
            this.ID_textBox1.Size = new System.Drawing.Size(100, 24);
            this.ID_textBox1.TabIndex = 4;
            // 
            // PW_textBox2
            // 
            this.PW_textBox2.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PW_textBox2.Location = new System.Drawing.Point(517, 12);
            this.PW_textBox2.Name = "PW_textBox2";
            this.PW_textBox2.PasswordChar = '*';
            this.PW_textBox2.Size = new System.Drawing.Size(100, 24);
            this.PW_textBox2.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Area_column,
            this.name_column,
            this.Theme_column});
            this.listView1.Enabled = false;
            this.listView1.Font = new System.Drawing.Font("문체부 돋음체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 196);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(502, 364);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Area_column
            // 
            this.Area_column.Text = "지역";
            this.Area_column.Width = 98;
            // 
            // name_column
            // 
            this.name_column.Text = "펜션 이름";
            this.name_column.Width = 216;
            // 
            // Theme_column
            // 
            this.Theme_column.Text = "테마";
            this.Theme_column.Width = 150;
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Enabled = false;
            this.Area_label.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Area_label.Location = new System.Drawing.Point(12, 92);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(56, 17);
            this.Area_label.TabIndex = 8;
            this.Area_label.Text = "지역별";
            // 
            // Book_button
            // 
            this.Book_button.BackColor = System.Drawing.SystemColors.Control;
            this.Book_button.Enabled = false;
            this.Book_button.Font = new System.Drawing.Font("문체부 돋음체", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Book_button.Location = new System.Drawing.Point(551, 379);
            this.Book_button.Name = "Book_button";
            this.Book_button.Size = new System.Drawing.Size(260, 116);
            this.Book_button.TabIndex = 13;
            this.Book_button.Text = "예약하기";
            this.Book_button.UseVisualStyleBackColor = false;
            this.Book_button.Click += new System.EventHandler(this.Book_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "텍스트 파일 (*.txt) |*.txt|모든 파일(*.*)|*.*";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton1.Location = new System.Drawing.Point(83, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 21);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "가평,양평";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton2.Location = new System.Drawing.Point(183, 92);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 21);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "경기";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton3.Location = new System.Drawing.Point(247, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 21);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "인천";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton4.Location = new System.Drawing.Point(311, 92);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 21);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "강원";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton5.Location = new System.Drawing.Point(375, 92);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(61, 21);
            this.radioButton5.TabIndex = 19;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "충청";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Enabled = false;
            this.radioButton6.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton6.Location = new System.Drawing.Point(438, 92);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(61, 21);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "전라";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Enabled = false;
            this.radioButton7.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton7.Location = new System.Drawing.Point(502, 92);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(96, 21);
            this.radioButton7.TabIndex = 21;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "경주,경상";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Enabled = false;
            this.radioButton8.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton8.Location = new System.Drawing.Point(602, 92);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(61, 21);
            this.radioButton8.TabIndex = 22;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "제주";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // Theme_label
            // 
            this.Theme_label.AutoSize = true;
            this.Theme_label.Enabled = false;
            this.Theme_label.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Theme_label.Location = new System.Drawing.Point(12, 136);
            this.Theme_label.Name = "Theme_label";
            this.Theme_label.Size = new System.Drawing.Size(56, 17);
            this.Theme_label.TabIndex = 23;
            this.Theme_label.Text = "테마별";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Enabled = false;
            this.radioButton10.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton10.Location = new System.Drawing.Point(481, 134);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(77, 21);
            this.radioButton10.TabIndex = 30;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "수영장";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Enabled = false;
            this.radioButton11.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton11.Location = new System.Drawing.Point(402, 134);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(77, 21);
            this.radioButton11.TabIndex = 29;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "글램핑";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Enabled = false;
            this.radioButton12.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton12.Location = new System.Drawing.Point(339, 134);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(61, 21);
            this.radioButton12.TabIndex = 28;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "독채";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Enabled = false;
            this.radioButton13.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton13.Location = new System.Drawing.Point(275, 134);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(61, 21);
            this.radioButton13.TabIndex = 27;
            this.radioButton13.TabStop = true;
            this.radioButton13.Text = "단체";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Enabled = false;
            this.radioButton14.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton14.Location = new System.Drawing.Point(211, 134);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(61, 21);
            this.radioButton14.TabIndex = 26;
            this.radioButton14.TabStop = true;
            this.radioButton14.Text = "커플";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Enabled = false;
            this.radioButton15.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton15.Location = new System.Drawing.Point(147, 134);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(61, 21);
            this.radioButton15.TabIndex = 25;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "가족";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Enabled = false;
            this.radioButton16.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioButton16.Location = new System.Drawing.Point(83, 134);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(61, 21);
            this.radioButton16.TabIndex = 24;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "휴식";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.Radio_button_check);
            // 
            // nofilter_button
            // 
            this.nofilter_button.BackColor = System.Drawing.SystemColors.Control;
            this.nofilter_button.Enabled = false;
            this.nofilter_button.Font = new System.Drawing.Font("문체부 돋음체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nofilter_button.Location = new System.Drawing.Point(684, 92);
            this.nofilter_button.Name = "nofilter_button";
            this.nofilter_button.Size = new System.Drawing.Size(142, 61);
            this.nofilter_button.TabIndex = 33;
            this.nofilter_button.Text = "필터 미적용";
            this.nofilter_button.UseVisualStyleBackColor = false;
            this.nofilter_button.Click += new System.EventHandler(this.nofilter_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_button.Font = new System.Drawing.Font("문체부 돋음체", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancel_button.Location = new System.Drawing.Point(551, 506);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(260, 54);
            this.cancel_button.TabIndex = 34;
            this.cancel_button.Text = "취소";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 76);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // Logout_button
            // 
            this.Logout_button.BackColor = System.Drawing.SystemColors.Control;
            this.Logout_button.Enabled = false;
            this.Logout_button.Font = new System.Drawing.Font("문체부 돋음체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Logout_button.Location = new System.Drawing.Point(633, 11);
            this.Logout_button.Name = "Logout_button";
            this.Logout_button.Size = new System.Drawing.Size(89, 32);
            this.Logout_button.TabIndex = 36;
            this.Logout_button.Text = "로그아웃";
            this.Logout_button.UseVisualStyleBackColor = false;
            this.Logout_button.Visible = false;
            this.Logout_button.Click += new System.EventHandler(this.Logout_button_Click);
            // 
            // Booklist_btn
            // 
            this.Booklist_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Booklist_btn.Enabled = false;
            this.Booklist_btn.Font = new System.Drawing.Font("문체부 돋음체", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Booklist_btn.Location = new System.Drawing.Point(684, 196);
            this.Booklist_btn.Name = "Booklist_btn";
            this.Booklist_btn.Size = new System.Drawing.Size(142, 63);
            this.Booklist_btn.TabIndex = 37;
            this.Booklist_btn.Text = "예약내역";
            this.Booklist_btn.UseVisualStyleBackColor = false;
            this.Booklist_btn.Click += new System.EventHandler(this.Booklist_btn_Click_1);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 613);
            this.Controls.Add(this.Booklist_btn);
            this.Controls.Add(this.Logout_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.nofilter_button);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton13);
            this.Controls.Add(this.radioButton14);
            this.Controls.Add(this.radioButton15);
            this.Controls.Add(this.radioButton16);
            this.Controls.Add(this.Theme_label);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.Book_button);
            this.Controls.Add(this.Area_label);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PW_textBox2);
            this.Controls.Add(this.ID_textBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Login_btn);
            this.Name = "main";
            this.Text = "팬션 예약";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Register_btn;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox ID_textBox1;
        private System.Windows.Forms.TextBox PW_textBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Area_column;
        private System.Windows.Forms.ColumnHeader Theme_column;
        private System.Windows.Forms.Label Area_label;
        private System.Windows.Forms.Button Book_button;
        private System.Windows.Forms.ColumnHeader name_column;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.Label Theme_label;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.Button nofilter_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Logout_button;
        private System.Windows.Forms.Button Booklist_btn;
    }
}

