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
    public partial class Complete : Form
    {
        public Complete()
        {
            InitializeComponent();
        }
        //Buy.cs와 Book.cs로부터 값을 받아옴
        private string user_value;
        private string name_value;
        private string date11_value;
        private string date12_value;
        private int person1_value;
        private string pay_value;
        private int price1_value;
        public string Passname//펜션이름
        {
            get { return this.name_value; }
            set { this.name_value = value; }
        }
        public string Passdate1//체크인 날짜
        {
            get { return this.date11_value; }
            set { this.date11_value = value; }
        }
        public string Passdate2//체크아웃 날짜
        {
            get { return this.date12_value; }
            set { this.date12_value = value; }
        }
        public int Passperson//인원 수
        {
            get { return this.person1_value; }
            set { this.person1_value = value; }
        }
        public string Passpay//결제방식
        {
            get { return this.pay_value; }
            set { this.pay_value = value; }
        }
        public int Passprice//결제가격
        {
            get { return this.price1_value; }
            set { this.price1_value = value; }
        }
        public string Passuser//예약한 유저
        {
            get { return this.user_value; }
            set { this.user_value = value; }
        }
        /// //////////////////////////////////////////////////////////////
        public void file_write()//예약 리스트 파일 작성
        {
            using (StreamWriter sw = new StreamWriter("Booklist.txt", true, Encoding.UTF8))
            {
                sw.WriteLine(Passuser + "/" + Passname + "/" + Passdate1 + "~" + Passdate2 + "/" +
                    Passperson + "/" + Passpay + "/" + Passprice);
                sw.Close();
            }
        }
        private void Complete_Load(object sender, EventArgs e)//Complete.cs가 열릴 때 바로 할 것
        {
            user_label.Text = Passuser + user_label.Text;
            name_label.Text = Passname;
            date1_label.Text = Passdate1;
            date2_label.Text = Passdate2;
            person_label.Text = Passperson.ToString();
            pay_label.Text = Passpay;
            price_label.Text = Passprice.ToString();
            if (pay_label.Text != "카카오페이")
                label6.Visible = true;
            file_write();
        }

        private void Pay_button_Click(object sender, EventArgs e)//취소버튼 누르면 메인화면으로
        {
            Application.OpenForms["Complete"].Close();
            Application.OpenForms["Buy"].Close();
            Application.OpenForms["Book"].Close();
        }
    }
}
