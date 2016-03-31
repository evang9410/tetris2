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

namespace MonoGame
{
    class ShapeSprite : DrawableGameComponent
    {
        // private IShape shape;
        private IBoard board;
        private Game game;
        private SpriteBatch spriteBatch;

        //for movedown frequency
        private Score score;
        private int counterMoveDown;

        //for keyboard input
        private KeyboardState oldstate;
        private int counterInput;
        private int threshold;

        //To Render
        private Texture2D filledBlock;

        public ShapeSprite(Game game, IBoard board, Score score)
            : base(game)
        {
            this.game = game;
            this.score = score;
        }
        /*     public Shape Shape
             {
                 get { return (Shape)shape; }
             }*/

        public override void Initialize()
        {
            oldstate = Keyboard.GetState();
            threshold = 6;
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            filledBlock = game.Content.Load<Texture2D>("FilledBlock");
            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            checkInput();
            base.Update(gameTime);
        }

        private void checkInput()
        {
            KeyboardState newState = Keyboard.GetState();
            if (newState.IsKeyDown(Keys.Right))
            {
                // If not down last update, key has just been pressed.
                if (!oldstate.IsKeyDown(Keys.Right))
                {
                    board.Shape.MoveRight();
                    counterMoveDown = 0; //reset counter with every new keystroke
                }
                else
                {
                    counterMoveDown++;
                    if (counterMoveDown > threshold)
                        board.Shape.MoveRight();
                }
            }
            else if (newState.IsKeyDown(Keys.Left))
            {
                if (!oldstate.IsKeyDown(Keys.Left))
                {
                    board.Shape.MoveLeft();
                    counterMoveDown = 0;
                }
                else
                {
                    counterMoveDown++;
                    if (counterMoveDown > threshold)
                        board.Shape.MoveLeft();
                }
            }
            else if (newState.IsKeyDown(Keys.Down))
            {
                if (!oldstate.IsKeyDown(Keys.Down))
                {
                    board.Shape.MoveDown();
                    counterMoveDown = 0; //reset counter with every new keystroke
                }
                else
                {
                    counterMoveDown++;
                    if (counterMoveDown > threshold)
                        board.Shape.MoveDown();
                }

            }

            else if (newState.IsKeyDown(Keys.LeftShift))
            {
                if (!oldstate.IsKeyDown(Keys.LeftShift))
                {
                    board.Shape.Rotate();
                    counterMoveDown = 0; //reset counter with every new keystroke
                }
                else
                {
                    counterMoveDown++;
                    if (counterMoveDown > threshold)
                        board.Shape.Rotate();
                }

            }

            else if (newState.IsKeyDown(Keys.Space))
            {
                if (!oldstate.IsKeyDown(Keys.Space))
                {
                    board.Shape.Drop();
                    counterMoveDown = 0; //reset counter with every new keystroke
                }
                else
                {
                    counterMoveDown++;
                    if (counterMoveDown > threshold)
                        board.Shape.Drop();
                }

            }



            // Improve/change the code above to also check forKeys.Left
            // Once finished checking all keys, update old state.
            oldstate = newState;
        }
    }
}
