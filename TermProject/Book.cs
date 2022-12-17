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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }
        //main.cs로부터 데이터를 받기 위함---------------------------------
        private string Book_value;
        private string customer_value;
        public string PassInform//지역과 펜션 이름을 받아옴
        {
            get { return this.Book_value; }
            set { this.Book_value = value; }
        }
        public string Passcustomer//고객 ID를 받아옴
        {
            get { return this.customer_value; }
            set { this.customer_value = value; }
        }
        //------------------------------------------------------------------
        private void set_listview(string filename)//파일로부터 펜션 정보를 읽어와 listview를 작성
        {
            string delimiter = "/";
            using (var sr = new StreamReader(filename, System.Text.Encoding.UTF8, true))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    // "/"를 기준으로 나누어 배열에 저장하고,
                    string[] columns = line.Split(new string[] { delimiter }, StringSplitOptions.None);
                    ListViewItem lvt = new ListViewItem(columns[0]);
                    //Subitem에 배열 각각의 요소를 저장
                    for (int c = 1; c < columns.Length; c++)
                    {
                        lvt.SubItems.Add(columns[c]);
                    }
                    listView1.Items.Add(lvt);

                }
            }
        }
        private void Book_Load(object sender, EventArgs e)
        {
            bookcheck();
            label6.Text = Passcustomer;
            label2.Text = Passcustomer + label2.Text;
            selectName_label.Text = PassInform;
            //main.cs에서 선택한 펜션의 방을 listview에 작성
            //펜션이 너무 많아서 한 지역당 5개 펜션만 방 리스트를 작성함. 총 40개
            if (selectName_label.Text == "가평,양평/가평 까사 32")
            {
                set_listview("gapyung1.txt");
            }
            else if (selectName_label.Text == "가평,양평/도도키즈풀빌라")
            {
                set_listview("gapyung2.txt");
            }
            else if (selectName_label.Text == "가평,양평/포세이돈 카라반")
            {
                set_listview("gapyung3.txt");
            }
            else if (selectName_label.Text == "가평,양평/가평 리버웨이브")
            {
                set_listview("gapyung4.txt");
            }
            else if (selectName_label.Text == "가평,양평/글램퍼스")
            {
                set_listview("gapyung5.txt");
            }
            else if (selectName_label.Text == "경기/파주 오블라디풀빌라")
            {
                set_listview("gyungi1.txt");
            }
            else if (selectName_label.Text == "경기/채움관광농원 글램핑")
            {
                set_listview("gyungi2.txt");
            }
            else if (selectName_label.Text == "경기/빵빵키즈풀빌라")
            {
                set_listview("gyungi3.txt");
            }
            else if (selectName_label.Text == "경기/파주 글램핑클럽레스피아")
            {
                set_listview("gyungi4.txt");
            }
            else if (selectName_label.Text == "경기/여주 해여림빌리지-H")
            {
                set_listview("gyungi5.txt");
            }
            else if (selectName_label.Text == "인천/강화 쥬라기카라반")
            {
                set_listview("incheon1.txt");
            }
            else if (selectName_label.Text == "인천/티라시아리조트")
            {
                set_listview("incheon2.txt");
            }
            else if (selectName_label.Text == "인천/영종 씨사이드 카라반")
            {
                set_listview("incheon3.txt");
            }
            else if (selectName_label.Text == "인천/강화 레스트혜윰펜션")
            {
                set_listview("incheon4.txt");
            }
            else if (selectName_label.Text == "인천/해밀펜션")
            {
                set_listview("incheon5.txt");
            }
            else if (selectName_label.Text == "강원/씨스파펜션")
            {
                set_listview("gangwon1.txt");
            }
            else if (selectName_label.Text == "강원/라헨느풀빌라H동")
            {
                set_listview("gangwon2.txt");
            }
            else if (selectName_label.Text == "강원/영월 히어리펜션")
            {
                set_listview("gangwon3.txt");
            }
            else if (selectName_label.Text == "강원/평창현대빌리지")
            {
                set_listview("gangwon4.txt");
            }
            else if (selectName_label.Text == "강원/강릉 풀빌라케이")
            {
                set_listview("gangwon5.txt");
            }
            else if (selectName_label.Text == "충청/태안 웰스리조트")
            {
                set_listview("chungcheong1.txt");
            }
            else if (selectName_label.Text == "충청/태안 모켄리조트")
            {
                set_listview("chungcheong2.txt");
            }
            else if (selectName_label.Text == "충청/학암포별빛바다글램핑")
            {
                set_listview("chungcheong3.txt");
            }
            else if (selectName_label.Text == "충청/학암포 글램핑")
            {
                set_listview("chungcheong4.txt");
            }
            else if (selectName_label.Text == "충청/공주 장승마을카라반")
            {
                set_listview("chungcheong5.txt");
            }
            else if (selectName_label.Text == "전라/여수 르그랑블루")
            {
                set_listview("jeonra1.txt");
            }
            else if (selectName_label.Text == "전라/여수예술랜드")
            {
                set_listview("jeonra2.txt");
            }
            else if (selectName_label.Text == "전라/여수 하이클래스153")
            {
                set_listview("jeonra3.txt");
            }
            else if (selectName_label.Text == "전라/여수 나폴리펜션")
            {
                set_listview("jeonra4.txt");
            }
            else if (selectName_label.Text == "전라/어반하임펜션")
            {
                set_listview("jeonra5.txt");
            }
            else if (selectName_label.Text == "경주,경상/문경 지가리조트")
            {
                set_listview("gyungju1.txt");
            }
            else if (selectName_label.Text == "경주,경상/경주 오푸스11 풀빌라")
            {
                set_listview("gyungju2.txt");
            }
            else if (selectName_label.Text == "경주,경상/부띠끄리조트 네르하21")
            {
                set_listview("gyungju3.txt");
            }
            else if (selectName_label.Text == "경주,경상/블루웨일 글램핑")
            {
                set_listview("gyungju4.txt");
            }
            else if (selectName_label.Text == "경주,경상/노아풀빌라 펜션")
            {
                set_listview("gyungju5.txt");
            }
            else if (selectName_label.Text == "제주/세도나중문 풀빌라")
            {
                set_listview("jeju1.txt");
            }
            else if (selectName_label.Text == "제주/라라제주 풀빌라")
            {
                set_listview("jeju2.txt");
            }
            else if (selectName_label.Text == "제주/사무이제주 풀빌라")
            {
                set_listview("jeju3.txt");
            }
            else if (selectName_label.Text == "제주/블리스제주 풀빌라")
            {
                set_listview("jeju4.txt");
            }
            else if (selectName_label.Text == "제주/세도나제주 풀빌라")
            {
                set_listview("jeju5.txt");
            }
        }
        public void bookcheck()//이미 예약이 된 객실은 회색으로 처리
        {
            string d = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string d2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            using (var sr = new StreamReader("Booklist.txt", Encoding.UTF8, true))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    for (int i = 0; i < listView1.Items.Count; i++) {//객실 listView의 모든 item 탐색
                        if (line.Contains(listView1.Items[i].SubItems[0].Text))
                            //Booklist.txt의 객실 이름과 listview subitem[0](객실 이름)이 같다면
                        {
                            if (line.Contains(d) || line.Contains(d2))//날짜 또한 겹친다면
                                listView1.Items[i].BackColor = Color.Gray;//item 배경을 회색으로
                            else//아니면,
                                listView1.Items[i].BackColor = Color.White;//item 배경을 흰색으로
                        }
                    }
                }
            }
        }

        private void settle_button_Click(object sender, EventArgs e)//예약하기 버튼
        {
            if (String.IsNullOrWhiteSpace(person_textBox.Text))//인원 수 미입력시
            {
                MessageBox.Show("인원 수를 입력해주세요", "인원 수 미입력");
            }
            else if (Convert.ToInt32(person_textBox.Text) > Convert.ToInt32(listView1.FocusedItem.SubItems[3].Text))
            {
                //객실의 최대 인원수를 초과했다면, 메세지박스 출력
                MessageBox.Show("인원 수를 초과했습니다. 다시 확인해주세요.", "인원 수 초과");
            }
            else if (dateTimePicker1.Value < DateTime.Now.AddDays(-1))
            {
                MessageBox.Show("체크인 날짜를 확인해 주세요", "날짜선택 오류");
            }
            else if (dateTimePicker1.Value.Date >= dateTimePicker2.Value.Date)//날짜 설정 안할 시에
            {
                MessageBox.Show("체크아웃 날짜를 확인해주세요", "날짜 미입력");
            }
            else if (listView1.FocusedItem.BackColor == Color.Gray)//선택한 item의 배경색이 회색이라면
            {
                MessageBox.Show("이미 예약된 객실입니다.", "예약 오류");//이미 예약된 곳임.
            }
            else//인원수, 날짜 모두 올바르게 입력했다면 결제하기 버튼 동작
            {
                //Buy.cs에 데이터를 넘겨줌.
                string hotel = PassInform;
                int person = Convert.ToInt32(person_textBox.Text);//인원 수 데이터
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");//체크인 날짜 데이터
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");//체크아웃 날짜 데이터
                string Name = listView1.FocusedItem.SubItems[0].Text;//객실 이름 데이터
                int Price = Convert.ToInt32(listView1.FocusedItem.SubItems[1].Text);//가격 데이터
                string user = label6.Text;
                DateTime T1 = DateTime.Parse(date1);//두 날짜간의 차이 일수로 구하기
                DateTime T2 = DateTime.Parse(date2);
                TimeSpan Ts = T2 - T1;
                int day = Ts.Days;//날짜 간의 일 수

                Buy showBuy = new Buy();//Buy.cs에 연결
                showBuy.Passhotel = hotel;
                showBuy.PassDate1 = date1;
                showBuy.PassDate2 = date2;
                showBuy.PassPerson = person;
                showBuy.PassName = Name;
                showBuy.PassPrice = Price;
                showBuy.PassUser = user;
                showBuy.PassDays = day;
                showBuy.ShowDialog();
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)//취소버튼
        {
            Application.OpenForms["Book"].Close();
        }

        private void person_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;   //숫자와 백스페이스만 입력가능
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            bookcheck();
        }
    }
}
