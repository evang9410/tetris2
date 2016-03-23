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
    class ScoreSprite: Game1
    {
        private Score score;
        private Game game;
        private SpriteBatch spriteBatch;

        //To render
        private SpriteFont font;

        public ScoreSprite(Game game, Score score)
        {
            this.game = game;
            this.score = score;
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
