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
    class BoardSprite: DrawableGameComponent
    {
        private IBoard board;
        private Game game;
        private SpriteBatch spriteBatch;

        //To render
        Texture2D emptyBlock;
        Texture2D filledBlock;

        //Constructor
        public BoardSprite(Game game, IBoard board): base(game)
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
            spriteBatch = new SpriteBatch(GraphicsDevice);

            emptyBlock = game.Content.Load<Texture2D>("EmptyBlock");
            filledBlock = game.Content.Load<Texture2D>("FilledBlock");

            //score font
            //board = new Board();

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            for(int x = 0; x < board.GetLength(0); x++)
            {
                for(int y = 0; y < board.GetLength(1); y++)
                {
                    if (board[x, y] != Color.Black)
                    {
                        spriteBatch.Draw(filledBlock, new Vector2(150+x*20, y*20), Color.White);
                    }
                    else
                    {
                        spriteBatch.Draw(emptyBlock, new Vector2(x, y), board[x, y]);
                    }
                }
            }

            //for loop to draw shape
            for (int i = 0; i < board.Shape.Length; i++)
            {
                spriteBatch.Draw(filledBlock, new Vector2(board.Shape[i].Position.X * 20, board.Shape[i].Position.Y * 20), board.Shape[i].Colour);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}
