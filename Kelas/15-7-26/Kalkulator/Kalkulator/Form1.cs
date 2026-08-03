namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBoxAngka1.Text);
            int angka2 = Convert.ToInt32(textBoxAngka2.Text);

            int hasil = angka1 + angka2;

            labelHasil.Text = hasil.ToString();
        }

        private void BtnKurang_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBoxAngka1.Text);
            int angka2 = Convert.ToInt32(textBoxAngka2.Text);

            int hasil = angka1 - angka2;

            labelHasil.Text = hasil.ToString();
        }

        private void BtnKali_Click(object sender, EventArgs e)
        {
            int angka1 = Convert.ToInt32(textBoxAngka1.Text);
            int angka2 = Convert.ToInt32(textBoxAngka2.Text);

            int hasil = angka1 * angka2;

            labelHasil.Text = hasil.ToString();
        }

        private void BtnBagi_Click(object sender, EventArgs e)
        {
            double angka1 = Convert.ToInt32(textBoxAngka1.Text);
            double angka2 = Convert.ToInt32(textBoxAngka2.Text);

            double hasil = angka1 / angka2;

            labelHasil.Text = hasil.ToString();
        }
    }
}
