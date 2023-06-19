namespace Heart_Animation_with_PNG_Win_Forms_MOO_ICT
{
    public partial class Form1 : Form
    {

        // create by mooict.com
        // for educational purpose only
        
        Random rand = new Random();
        List<Heart> hearts = new List<Heart>();

        public Form1()
        {
            InitializeComponent();
            SetUpForm();
        }


        private void SetUpForm()
        {
            this.BackgroundImage = Image.FromFile("images/bg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            for (int i = 0; i < 50; i++)
            {
                Heart newHeart = new Heart();
                newHeart.PositionX = rand.Next(10, this.ClientSize.Width - 100);
                newHeart.PositionY = this.ClientSize.Height + rand.Next(300, 1200);
                hearts.Add(newHeart);
            }


        }

        private void TimerEvent(object sender, EventArgs e)
        {
            foreach (Heart newHeart in hearts.ToList())
            {
                newHeart.AnimateHeart();

                newHeart.PositionY -= newHeart.SpeedY;


                if (newHeart.PositionY < -100)
                {
                    newHeart.PositionY = this.ClientSize.Height + rand.Next(200, 500);
                    newHeart.PositionX = rand.Next(10, this.ClientSize.Width - 100);
                }


            }


            this.Invalidate();
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;


            foreach (Heart newHeart in hearts.ToList())
            {
                Canvas.DrawImage(newHeart.heart, newHeart.PositionX, newHeart.PositionY, newHeart.width, newHeart.height);
            }
        }
    }
}