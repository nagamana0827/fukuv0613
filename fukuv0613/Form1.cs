namespace fukuv0613
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx = -vx;
            vy = -vy;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
            if (label1.Left < 0)
            {
                label1.Left = 0;
                vx = -vx;
            }
           
            
            
        }

    }
    

}
