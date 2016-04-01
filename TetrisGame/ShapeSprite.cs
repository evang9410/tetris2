using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MonoGame {
    class ShapeSprite : DrawableGameComponent {
        private IBoard board;
        private Game game;
        private SpriteBatch spriteBatch;

        private Score score;
        private int counterMoveDown;
        int freq;

        private KeyboardState oldstate;
        private int threshold;

        private Texture2D filledBlock;

        public ShapeSprite(Game game, IBoard board, Score score) : base(game) {
            this.game = game;
            this.score = score;
            this.board = board;
        }

        public override void Initialize() {
            oldstate = Keyboard.GetState();
            threshold = 10;
            freq = 0;
            base.Initialize();
        }

        protected override void LoadContent() {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            filledBlock = game.Content.Load<Texture2D>("FilledBlock");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime) {
            checkInput();

            if (freq > (11 - score.Level) * 3) {
                freq = 0;
                board.Shape.MoveDown();
            } else {
                freq++;
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime) {
            spriteBatch.Begin();
            for (int i = 0; i < board.Shape.Length; i++) {
                spriteBatch.Draw(filledBlock, new Vector2(board.Shape[i].Position.X * 20 + 2, board.Shape[i].Position.Y * 20 + 2), board.Shape[i].Color);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

        private void checkInput() {
            KeyboardState newState = Keyboard.GetState();

            // Checking for right arrow
            if (newState.IsKeyDown(Keys.Right)) {
                if (!oldstate.IsKeyDown(Keys.Right)) {
                    board.Shape.MoveRight();
                    counterMoveDown = 0;
                } else {
                    counterMoveDown++;

                    if (counterMoveDown > threshold) {
                        board.Shape.MoveRight();
                    }
                }
            }

            // Checking for left arrow
            if (newState.IsKeyDown(Keys.Left)) {
                if (!oldstate.IsKeyDown(Keys.Left)) {
                    board.Shape.MoveLeft();
                    counterMoveDown = 0;
                } else {
                    counterMoveDown++;

                    if (counterMoveDown > threshold) {
                        board.Shape.MoveLeft();
                    }
                }
            }

            // Checking for down arrow
            if (newState.IsKeyDown(Keys.Down)) {
                if (!oldstate.IsKeyDown(Keys.Down)) {
                    board.Shape.Drop();
                    counterMoveDown = 0;
                } else {
                    counterMoveDown++;
                }
            }

            // Checking for space
            if (newState.IsKeyDown(Keys.Space)) {
                if (!oldstate.IsKeyDown(Keys.Space)) {
                    board.Shape.Rotate();
                    counterMoveDown = 0;
                } else {
                    counterMoveDown++;
                }
            }

            oldstate = newState;
        }
    }
}
