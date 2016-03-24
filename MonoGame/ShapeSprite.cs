using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tetris;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame
{
    class ShapeSprite : DrawableGameComponent
    {
        private IShape shape;
        private Game game;
        private SpriteBatch spriteBatch;

        //TO Render
        private Texture2D filledBlock;

        //for movedown frequency
        private Score score;
        private int counterMoveDown;
        
        //for keyboard input
        private KeyboardState oldstate;
        private int counterInput;
        private int threshold;

        public ShapeSprite(Game game, IBoard board, Score score)
            : base(game)
        {
            this.game = game;
            this.score = score;
        }
    }
}
