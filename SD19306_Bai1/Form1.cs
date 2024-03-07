namespace SD19306_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            txt_MSV.Text = "PH12345";
            txt_hoten.Text = "Quỳnh Bei";
            rtxt_dchi.Text = "Vin hôm sờ mát ci ti";
            rbtn_kbeauty.Checked = true;
            rbtn_nam.Checked = true;
            cbx_CSharp.Checked = true;
            cbx_SQL.Checked = true;
            Show();
        }

        //tự viết 1 hàm để hiển thị dtgview
        public void Show()
        {
            //B1: Tạo Cột
            //xác định có bao nhiêu cột
            dtgView.ColumnCount = 3;
            //đặt tên cột
            dtgView.Columns[0].Name = "MSV";
            dtgView.Columns[1].Name = "Họ Tên";
            dtgView.Columns[2].Name = "Giới Tính";
            //B2: Tạo dòng
            //add dữ liệu theo thứ tự các cột
            dtgView.Rows.Add(txt_MSV.Text, txt_hoten.Text, rbtn_nam.Text);
        }
    }
}