using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    //Color.Aquamarine
    public class ShapeI : Shape
    {
        private Block[] defaultPos;
        private Block[] rotation1;
        public ShapeI() : base()
        {
            block[0] = new Block(Color.Aquamarine, new Point(0, 0));

            block[1] = new Block(Color.Aquamarine, new Point(0, 1));
            block[2] = new Block(Color.Aquamarine, new Point(0, 2));
            block[3] = new Block(Color.Aquamarine, new Point(0, 3));

            defaultPos = block;
            rotation1[0] = new Block(Color.Aquamarine, new Point(0, 0));
            rotation1[1] = new Block(Color.Aquamarine, new Point(1, 0));
            rotation1[2] = new Block(Color.Aquamarine, new Point(2, 0));
            rotation1[3] = new Block(Color.Aquamarine, new Point(3, 0));


        }
        public override void Reset()
        {
            block = defaultPos;
            currentRotation = 0;
        }

        public override void Rotate()
        {
            if (currentRotation == 1)
            {
                block = rotation1;
            }
            else
                block = defaultPos;
        }
    }
}
