namespace ImageListKomponenta
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[1];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i % 2 == 0)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
            else
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            i++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}