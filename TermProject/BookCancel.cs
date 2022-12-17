using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class BookCancel : Form
    {
        public BookCancel()
        {
            InitializeComponent();
        }
        string customer;
        public string Passcustomer//고객 ID를 받아옴
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        private void BookCancel_Load(object sender, EventArgs e)
        {
            label2.Text = Passcustomer + label2.Text;
            set_booklist();
        }
        private void set_booklist()//리스트뷰에 현재 고객의 예약내역 작성
        {
            string delimiter = "/";
            using (var sr = new StreamReader("Booklist.txt", System.Text.Encoding.UTF8, true))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns = line.Split(new string[] { delimiter }, StringSplitOptions.None);
                    if (columns[0] == Passcustomer)//예약내역에 있는 ID가 현재 ID와 같다면 리스트뷰에 추가
                    {
                        ListViewItem lvt = new ListViewItem(columns[1]);
                        for (int c = 2; c < columns.Length; c++)
                        {
                            lvt.SubItems.Add(columns[c]);
                        }
                        listView1.Items.Add(lvt);
                    }

                }
            }
        }
        private void BookCancel_button_Click(object sender, EventArgs e)//예약취소버튼
        {
            if (listView1.SelectedIndices.Count > 0)//리스트뷰에서 아이템을 클릭 했는지 점검
            {
                string book;
                book = Passcustomer;
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    book = book + "/" + listView1.FocusedItem.SubItems[i].Text.ToString();
                }

                string[] line = File.ReadAllLines("Booklist.txt");//예약내역 파일의 값들을 모두 배열로
                string[] newline = new string[line.Length];//새로 저장할 배열
                for (int i = 0; i < line.Length; i++)//예약내역파일에 listview에서 선택한 예약이 있다면,
                                                     //그 예약을 배열에서 제거시키고,그 배열을 다시 파일에 복사
                {
                    if (line[i] == book)
                        newline[i] = "";
                    else
                        newline[i] = line[i];
                }
                File.WriteAllText("Booklist.txt", String.Empty);//Booklist 파일을 싹 지움
                using (StreamWriter sw = new StreamWriter("Booklist.txt", true, Encoding.UTF8))
                {//다시 예약내역 파일 작성
                    for (int i = 0; i < newline.Length; i++)
                        sw.WriteLine(newline[i]);
                    sw.Close();
                }
                MessageBox.Show("예약이 취소되었습니다.", "예약취소");
                Application.OpenForms["BookCancel"].Close();
            }
            else
                MessageBox.Show("취소하실 예약내역을 선택해주세요.", "취소할 예약 내역 미선택");
        }
    }
}
