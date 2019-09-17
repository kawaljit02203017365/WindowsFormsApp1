using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RussianRoulleteclass
    {
        public int bulletespinedgun;
        public bool WinningGame, looseGame;
        public bool shoot_bullet;
        public int totalshottofire = 1;
        public int loadfired;
        Random numb = new Random();
        public void load()
        {
            loadfired = 1;
        }

        public void spin()
        {
            bulletespinedgun = numb.Next(1, 7);
        }

        public bool shootbullet()
        {
            if (loadfired == bulletespinedgun)
            {
                shoot_bullet = true;
            }
            else if (bulletespinedgun == 6)
            {
                bulletespinedgun = 1;
                shoot_bullet = false;
            }
            else
            {
                bulletespinedgun++;
                shoot_bullet = false;
            }

            return shoot_bullet;
        }
       
    }
}