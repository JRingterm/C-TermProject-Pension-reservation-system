using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            pictureBox1.Load("logo.png");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        int logincheck = 0;
        int loginflag = 0;
        private void Login_btn_Click(object sender, EventArgs e)//로그인 버튼 클릭시
        {
            if (String.IsNullOrWhiteSpace(ID_textBox1.Text))
            {
                MessageBox.Show("ID를 입력해주세요", "ID 미입력");
            }
            else if (String.IsNullOrWhiteSpace(PW_textBox2.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요", "비밀번호 미입력");
            }
            else
            {
                using (var sr = new StreamReader("userinfo.txt", Encoding.UTF8, true))
                {
                    string line = null;
                    string IDPW = ID_textBox1.Text + "/" + PW_textBox2.Text;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains(IDPW))
                        {
                            MessageBox.Show("로그인 되었습니다.", "로그인 완료");
                            //사용 불가하던 모든 기능들이 일어남.
                            Area_label.Enabled = true;
                            Theme_label.Enabled = true;
                            radioButton1.Enabled = true;
                            radioButton2.Enabled = true;
                            radioButton3.Enabled = true;
                            radioButton4.Enabled = true;
                            radioButton5.Enabled = true;
                            radioButton6.Enabled = true;
                            radioButton7.Enabled = true;
                            radioButton8.Enabled = true;
                            radioButton10.Enabled = true;
                            radioButton11.Enabled = true;
                            radioButton12.Enabled = true;
                            radioButton13.Enabled = true;
                            radioButton14.Enabled = true;
                            radioButton15.Enabled = true;
                            radioButton16.Enabled = true;
                            listView1.Enabled = true;
                            Book_button.Enabled = true;
                            nofilter_button.Enabled = true;
                            Booklist_btn.Enabled = true;
                            ID_textBox1.Enabled = false;
                            PW_textBox2.Enabled = false;
                            Login_btn.Enabled = false;
                            Login_btn.Visible = false;
                            Logout_button.Enabled = true;
                            Logout_button.Visible = true;

                            logincheck = 1;
                            loginflag = 1;
                            break;
                        }
                        else //파일에 입력한 id,비밀번호가 없다면
                        {
                            if (line == null)
                                loginflag = 0;//로그인 플래그를 0으로
                        }
                    }
                    if (loginflag == 0)//로그인 플래그가 0이면 로그인 실패
                        MessageBox.Show("아이디 또는 패스워드가 일치하지 않습니다.", "로그인 실패");
                }
            }
        }
        private void Register_btn_Click(object sender, EventArgs e)//회원가입 버튼 클릭시
        {
            Register showRegister = new Register();
            showRegister.ShowDialog();
        }

        private void Book_button_Click(object sender, EventArgs e)//예약버튼 클릭시
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                string customer = ID_textBox1.Text;
                string Area = listView1.FocusedItem.SubItems[0].Text;
                string Name = listView1.FocusedItem.SubItems[1].Text;
                Book showBook = new Book();//Book.cs에 데이터 넘김.
                showBook.Passcustomer = customer;
                showBook.PassInform = Area + "/" + Name;
                showBook.ShowDialog();
            }
            else
            {
                MessageBox.Show("예약하실 펜션을 클릭해주세요", "펜션 미선택");
            }
        }
        private void Radio_button_check(object sender, EventArgs e)//필터 라디오버튼 클릭시 리스트뷰 변화
        {
            RadioButton _radio = (RadioButton)sender;
            listView1.Items.Clear();
            string delimiter = "/";// "/"을 기준으로 나눔
            //파일로부터 펜션 정보를 읽어와서 listview에 작성
            using (var sr = new StreamReader("main.txt", System.Text.Encoding.UTF8, true))
            {
                string line = null;
                string search = _radio.Text;
                while ((line = sr.ReadLine()) != null)
                { 
                    if (line.Contains(search))
                    {
                        string[] columns2 = line.Split(new string[] { delimiter }, StringSplitOptions.None);
                        ListViewItem lvt = new ListViewItem(columns2[0]);
                        for (int c = 1; c < columns2.Length; c++)
                        {
                            lvt.SubItems.Add(columns2[c]);//listview의 서브트리에 추가
                        }
                        listView1.Items.Add(lvt);
                    }
                    else
                        continue;
                }
            }
        }
        private void set_main()//프로그램 시작시 실행되는 함수
        {
            string delimiter = "/";
            using (var sr = new StreamReader("main.txt", System.Text.Encoding.UTF8, true))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split(new string[] { delimiter }, StringSplitOptions.None);
                    ListViewItem lvt = new ListViewItem(columns[0]);
                    for (int c = 1; c < columns.Length; c++)
                    {
                        lvt.SubItems.Add(columns[c]);
                    }
                    listView1.Items.Add(lvt);

                }
            }
        }
        private void main_Load(object sender, EventArgs e)
        {
            set_main();
        }

        private void nofilter_button_Click(object sender, EventArgs e)//필터적용x
        {
            listView1.Items.Clear();
            set_main();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.OpenForms["main"].Close();
        }

        private void Logout_button_Click(object sender, EventArgs e)
        {
            if (logincheck == 1)
            {
                MessageBox.Show("로그아웃 되었습니다.", "로그아웃");
                set_main();
                ID_textBox1.Clear();
                PW_textBox2.Clear();
                Area_label.Enabled = false;
                Theme_label.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
                radioButton10.Enabled = false;
                radioButton11.Enabled = false;
                radioButton12.Enabled = false;
                radioButton13.Enabled = false;
                radioButton14.Enabled = false;
                radioButton15.Enabled = false;
                radioButton16.Enabled = false;
                listView1.Enabled = false;
                Book_button.Enabled = false;
                nofilter_button.Enabled = false;
                Booklist_btn.Enabled = false;
                ID_textBox1.Enabled = true;
                PW_textBox2.Enabled = true;
                Login_btn.Enabled = true;
                Login_btn.Visible = true;
                Logout_button.Enabled = false;
                Logout_button.Visible = false;

                logincheck = 0;
                loginflag = 0;
            }
        }
        private void Booklist_btn_Click_1(object sender, EventArgs e)
        {
            string cust_name = ID_textBox1.Text;
            BookCancel showCancel = new BookCancel();//Book.cs에 데이터 넘김.
            showCancel.Passcustomer = cust_name;
            showCancel.ShowDialog();
        }
    }
}

