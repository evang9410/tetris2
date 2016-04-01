﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tetris;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame {
    class ScoreSprite : DrawableGameComponent {
        private Score score;

        private Game game;
        private SpriteBatch spriteBatch;

        //To render
        private SpriteFont font;

        public ScoreSprite(Game game, Score score) : base(game) {
            this.game = game;
            this.score = score;
        }

        public override void Initialize() {
            base.Initialize();
        }
        protected override void LoadContent() {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = game.Content.Load<SpriteFont>("scorefont");
            base.LoadContent();

        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime) {
            spriteBatch.Begin();

            spriteBatch.DrawString(font, "Level: " + score.Level, new Vector2(204, 2), Color.Black);
            spriteBatch.DrawString(font, "Lines: " + score.Lines, new Vector2(204, 22), Color.Black);
            spriteBatch.DrawString(font, "Points: " + score.Points, new Vector2(204, 42), Color.Black);

            spriteBatch.End();
            base.Draw(gameTime);
        }

    }
}
