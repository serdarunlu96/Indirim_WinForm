namespace Indirim_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTutar.Text))
                MessageBox.Show("Lutfen Tutarý Bos Girmeyiniz!");
            else if (!double.TryParse(txtTutar.Text, out double sonuc))
                MessageBox.Show("Lutfen Sayi Giriniz:");
            else if (!chcNakitInd.Checked && !chcKampanyaInd.Checked)
                MessageBox.Show("Tutar: " + sonuc);
            else if (chcNakitInd.Checked && !chcKampanyaInd.Checked)
                MessageBox.Show("Tutar: " + sonuc * 0.95);
            else if (!chcNakitInd.Checked && chcKampanyaInd.Checked)
                MessageBox.Show("Tutar: " + sonuc * 0.9);
            else if (chcNakitInd.Checked && chcKampanyaInd.Checked)
                MessageBox.Show("Tutar: " + sonuc * 0.85);
        }
    }
}