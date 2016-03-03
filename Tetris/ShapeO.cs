using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Tetris
{
    public class ShapeO : Shape
    {
        public ShapeO()
            : base()
        {
            for (int i = 0; i < block.Length; i++)
            {
                block[i] = new Block(Color.Yellow);
            }
        }

        public void Rotate()
        {

        }
        public void Rest()
        {

        }
    }
}
