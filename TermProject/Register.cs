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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        //회원정보 파일에 쓰기
        public void FileWrite()
        {
            using(StreamWriter sw = new StreamWriter("userinfo.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(Idregister_textbox.Text + "/" + pwregister_textbox.Text + "/" 
                    + pnregister_combobox.Text + pnregister_textbox.Text + pnregister_textbox2.Text);
                sw.Close();
            }
        }
        //회원가입 버튼 눌렀을 시
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Idregister_textbox.Text))
            {
                MessageBox.Show("사용하실 ID를 입력해주세요", "ID 미입력");
            }
            else if (String.IsNullOrWhiteSpace(pwregister_textbox.Text))
            {
                MessageBox.Show("사용하실 비밀번호를 입력해주세요", "비밀번호 미입력");
            }
            else if (String.IsNullOrWhiteSpace(pnregister_textbox.Text))
            {
                MessageBox.Show("사용하실 전화번호를 입력해주세요", "전화번호 미입력");
            }
            else if (String.IsNullOrWhiteSpace(pnregister_textbox2.Text))
            {
                MessageBox.Show("사용하실 전화번호를 입력해주세요", "전화번호 미입력");
            }
            else
            {
                FileWrite();
                MessageBox.Show("회원가입이 완료되었습니다.", "회원가입완료");
                Application.OpenForms["Register"].Close();
            }
        }
        //지역번호 초기값 설정
        private void Register_Load(object sender, EventArgs e)
        {
            pnregister_combobox.SelectedIndex = 0;
        }
        //취소버튼
        private void cancel_button_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Register"].Close();
        }
        //전화번호는 숫자와 백스페이스만 입력받도록
        private void pnregister_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
        private void pnregister_textbox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
