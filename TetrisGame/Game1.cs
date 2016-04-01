using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using Tetris;

namespace MonoGame {
    public class Game1 : Game {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private BoardSprite boardSprite;
        private ShapeSprite shapeSprite;
        private ScoreSprite scoreSprite;

        public Game1() : base() {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferHeight = 404;
            graphics.PreferredBackBufferWidth = 304;
        }

        protected override void Initialize() {
            IBoard board = new Board();
            Score score = new Score((Board)board);

            boardSprite = new BoardSprite(this, board);
            shapeSprite = new ShapeSprite(this, board, score);
            scoreSprite = new ScoreSprite(this, score);

            Components.Add(boardSprite);
            base.Initialize();
            Components.Add(scoreSprite);
            base.Initialize();
            Components.Add(shapeSprite);
            base.Initialize();

            board.GameOver += gameOver;
        }

        protected override void LoadContent() {
            spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            GraphicsDevice.Clear(new Color(80, 80, 80));
            var fps = 1 / gameTime.ElapsedGameTime.TotalSeconds;
            base.Draw(gameTime);
        }

        private bool gameOver(bool isOver) {
            Components.Remove(shapeSprite);
            this.Exit(); // Exiting because game reached end
            return true;
        }

    }
}
