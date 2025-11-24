using System.Runtime.InteropServices;

namespace roteiro_8
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form form = new Forms();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button4.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button4.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form3>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form4>();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form5>();
        }
    }
}
