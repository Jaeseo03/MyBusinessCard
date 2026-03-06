using System.Diagnostics;

namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        // [수정] 사진 상태를 저장할 변수를 클래스 상단에 선언해야 합니다.
        private bool isFirstImage = true;

        public Form1()
        {
            InitializeComponent();

            // [추가] 실행 시 기본 사진을 photo1(MyBusinessCardPhoto1)으로 설정합니다.
            if (Properties.Resources.MyBusinessCardPhoto1 != null)
            {
                pictureBox1.Image = Properties.Resources.MyBusinessCardPhoto1;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // --- 마우스 효과 기능 추가 ---
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.Fixed3D; // 마우스 올리면 3D 경계선
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.None; // 마우스 떼면 경계선 제거
        }
        // --------------------------

        private void label2_Click(object sender, EventArgs e)
        {
        }

        // 1. 깃허브 주소로 가기 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Jaeseo03/WinFormsApp3";

            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("링크를 열 수 없습니다: " + ex.Message);
            }
        }

        // 2. 명함 사진 바꾸기 버튼 (photo1 <-> photo2 토글)
        private void button2_Click(object sender, EventArgs e)
        {
            // 리소스 이름이 정확한지 확인하세요. 
            // 여기서는 코드에 적어주신 MyBusinessCardPhoto1, 2를 사용합니다.
            if (isFirstImage)
            {
                pictureBox1.Image = Properties.Resources.MyBusinessCardPhoto2;
                isFirstImage = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.MyBusinessCardPhoto1;
                isFirstImage = true;
            }

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // 3. 배경 색상 변경 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }
    }
}