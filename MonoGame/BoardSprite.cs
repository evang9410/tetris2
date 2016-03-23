using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Tetris;

namespace MonoGame
{
    class BoardSprite: Game1
    {
        private IBoard board;
        private Game game;
        private SpriteBatch spriteBatch;

        //To render
        Texture2D emptyBlock;
        Texture2D filledBlock;

        //Constructor
        public BoardSprite(Game game, IBoard board)
        {
            this.game = game;
            this.board = board;
        }

        public override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

    }
}
