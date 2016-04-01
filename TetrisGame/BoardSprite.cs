using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Tetris;

namespace MonoGame {
    class BoardSprite : DrawableGameComponent {
        private IBoard board;
        private Game game;
        private SpriteBatch spriteBatch;
        
        Texture2D emptyBlock;
        Texture2D filledBlock;

        public BoardSprite(Game game, IBoard board) : base(game) {
            this.game = game;
            this.board = board;
        }

        public override void Initialize() {
            base.Initialize();
        }

        protected override void LoadContent() {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            emptyBlock = game.Content.Load<Texture2D>("EmptyBlock");
            filledBlock = game.Content.Load<Texture2D>("FilledBlock");

            base.LoadContent();
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime) {
            spriteBatch.Begin();

            for (int x = 0; x < board.GetLength(0); x++) {
                for (int y = 0; y < board.GetLength(1); y++) {
                    if (board[x, y] != Color.Black) {
                        // Draw filled block since block isn't black
                        spriteBatch.Draw(filledBlock, new Vector2(x * 20 + 2, y * 20 + 2), board[x, y]);
                    } else {
                        // Draw empty block since block is black
                        spriteBatch.Draw(emptyBlock, new Vector2(x * 20 + 2, y * 20 + 2), new Color(40, 40, 40));
                    }
                }
            }

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
