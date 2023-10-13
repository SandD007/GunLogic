using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGun
{
    public class PaintBallGun
    {
        public PaintBallGun(int balls, int magazineSize, bool loaded)
        {
            this.balls = balls;
            MagazineSize = magazineSize;
            if(!loaded) Reload();
        }
        public int MagazineSize { get; private set; } = 16;
        private int balls = 16;

        public int BallsLoaded { get; private set; }

        public int Balls
        {
            get { return balls; }

            set
            {
                if (value > 0)
                {
                    balls = value;
                    Reload();
                }
            }
        }

        public bool IsEmty() { return BallsLoaded == 0; }

        public void Reload()
        {
            if(balls > MagazineSize)
            {
                BallsLoaded = MagazineSize;
            }
            else BallsLoaded = balls;
        }

        public bool Shoot()
        {
            if(BallsLoaded == 0) return false;
            BallsLoaded--;
            balls--;
            return true;
        }
    }
}
