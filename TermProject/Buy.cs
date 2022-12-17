using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }
        //Book.cs로부터 데이터를 받기 위함-----------------
        private string hotel_value;
        private string date1_value;
        private string date2_value;
        private int person_value;
        private string name_value;
        private int price_value;
        private string user_value;
        private int days_value;
        public string Passhotel//지역 데이터
        {
            get { return this.hotel_value; }
            set { this.hotel_value = value; }
        }
        public string PassDate1//체크인 날짜
        {
            get { return this.date1_value; }
            set { this.date1_value = value; }
        }
        public string PassDate2//체크아웃 날짜
        {
            get { return this.date2_value; }
            set { this.date2_value = value; }
        }
        public int PassDays//총 숙박 일수
        {
            get { return this.days_value; }
            set { this.days_value = value; }
        }
        public int PassPerson//인원 수
        {
            get { return this.person_value; }
            set { this.person_value = value; }
        }
        public string PassName//펜션 이름
        {
            get { return this.name_value; }
            set { this.name_value = value; }
        }
        public int PassPrice//가격
        {
            get { return this.price_value; }
            set { this.price_value = value; }
        }
        public string PassUser//예약한 유저
        {
            get { return this.user_value; }
            set { this.user_value = value; }
        }
        //-------------------------------------------------------------
        private void radioButton1_CheckedChanged(object sender, EventArgs e)//신용카드 라디오버튼
        {
            label7.Enabled = false; //카카오페이에 관한 이용약관 글 레이블을 모두 없앰
            label7.Visible = false;
            label8.Enabled = false;
            label8.Visible = false;
            label9.Enabled = false;
            label9.Visible = false;
            discount_label.Enabled = true;//할인정보 띄움
            discount_label.Visible = true;
            card_comboBox.Enabled = true; //카드 선택 콤보박스 띄움
            card_comboBox.Visible = true;
            Pay_button.Enabled = true; //결제하기 버튼 활성화
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)//카카오페이 라디오버튼
        {
            card_comboBox.Enabled = false; //카드선택 콤보박스 없앰
            card_comboBox.Visible = false;
            discount_label.Enabled = false;//카드 할인정보 없앰
            discount_label.Visible = false;
            label7.Enabled = true;//카카오페이 이용약관 글 레이블을 띄움
            label7.Visible = true;
            label8.Enabled = true;
            label8.Visible = true;
            label9.Enabled = true;
            label9.Visible = true;
            Pay_button.Enabled = true;//결제하기 버튼 활성화
        }

        private void Buy_Load(object sender, EventArgs e)//Buy.cs창이 열리자마자 할 것
        {
            int days2 = PassDays + 1;//n박n+1일을 표시하기 위한 변수
            int result_price = (PassPrice * PassDays);//숙박 일수와 가격을 곱해서 총 가격 산출
            name_label.Text = Passhotel + "/" + PassName;
            date1_label.Text = PassDate1;
            date2_label.Text = PassDate2;
            person_label.Text = PassPerson.ToString();
            price_label.Text = result_price.ToString();
            days1_label.Text = PassDays.ToString() + days1_label.Text;
            days2_label.Text = days2.ToString() + days2_label.Text;
            
        }
        int shinhanflag = 0;
        float discount = 0;//할인 퍼센트
        private void card_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {//신한카드 할인
            Complete showComple = new Complete();
            //선택한 카드가 신한, 신한포인트 카드라면
            if (card_comboBox.SelectedItem.ToString() == "신한" || card_comboBox.SelectedItem.ToString() == "신한포인트")
            {
                discount = 10;//10% 할인
                label2.Enabled = true;
                label2.Visible = true;
                shinhanflag = 1;
            }
            else//아니라면 미적용
            {
                discount = 0;
                label2.Enabled = false;
                label2.Visible = false;
                shinhanflag = 0;
            }

        }
        

        private void Pay_button_Click(object sender, EventArgs e)//결제하기 버튼 클릭 시
        {
            string cardpay;
            string kakaopay;
            string name = name_label.Text;
            string date1 = PassDate1;
            string date2 = PassDate2;
            int person = PassPerson;
            string user = PassUser;           
            int price = PassPrice * PassDays;
            float i = (float)price;//할인을 위한 정수->실수 형변환
            float discount_price =i - (i * (discount/100));//할인 적용 가격

            Complete showComple = new Complete();//Complete.cs에 관련 데이터 넘김.
            showComple.Passname = name;
            showComple.Passdate1 = date1;
            showComple.Passdate2 = date2;
            showComple.Passperson = person;
            if (shinhanflag == 1)//신한카드로 결제했다면
                showComple.Passprice = (int)discount_price;//할인 적용
            else//아니라면
                showComple.Passprice = price;//할인 미적용
            showComple.Passuser = user;
            if (card_radiobutton.Checked)//신용카드 라디오버튼이 체크됐다면
            {
                if (card_comboBox.SelectedIndex <= -1)//카드 선택을 안했다면,
                {
                    MessageBox.Show("결제하실 카드를 선택해주세요", "카드 미선택");
                }
                else//카드 선택을 완료하면 진행
                {
                    cardpay = card_comboBox.SelectedItem.ToString();
                    showComple.Passpay = cardpay;
                    showComple.ShowDialog();
                }
            }
            else if (kakao_radiobutton.Checked)//카카오페이 라디오버튼이 체크됐다면
            {
                kakaopay = kakao_radiobutton.Text;
                showComple.Passpay = kakaopay;
                showComple.ShowDialog();
            } 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)//이용동의 체크박스
        {
            if (checkBox1.Checked)//이용동의 체크박스에 체크를 안하면, 결제 기능을 사용할 수 없음
            {
                label5.Enabled = true;
                card_radiobutton.Enabled = true;
                kakao_radiobutton.Enabled = true;
            }
            else
            {
                label5.Enabled = false;
                card_radiobutton.Enabled = false;
                kakao_radiobutton.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)//취소버튼
        {
            Application.OpenForms["Buy"].Close();
        }
        
    }
}
