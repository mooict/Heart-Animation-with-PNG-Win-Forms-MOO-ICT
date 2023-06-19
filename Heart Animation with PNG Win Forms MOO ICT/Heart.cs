using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Heart_Animation_with_PNG_Win_Forms_MOO_ICT
{
    internal class Heart
    {

        // create by mooict.com
        // for educational purpose only

        public int PositionX;
        public int PositionY;
        public int SpeedY;
        public int height;
        public int width;
        public Image heart;

        Random rand = new Random();
        int frames;


        public Heart()
        {
            heart = Image.FromFile("images/1.png");
            height = 85;
            width = 105;

            SpeedY = rand.Next(2, 10);
        }

        public void AnimateHeart()
        {

            if (frames < 11)
            {
                frames += 1;

                heart = Image.FromFile("images/" + frames + ".png");

            }
            else
            {
                frames = 0;
            }

        }
    }
}
