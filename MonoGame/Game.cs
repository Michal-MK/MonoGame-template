using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame {
	public class Game : Microsoft.Xna.Framework.Game {
		private readonly GraphicsDeviceManager _gdManager;
		private readonly SpriteBatch _renderer;

		public Game() {
			_gdManager = new GraphicsDeviceManager(this);
			_renderer = new SpriteBatch(GraphicsDevice);
			Content.RootDirectory = "Content";
		}

		protected override void Initialize() {
			//Inital setup, runs once. (Základní nastaení, voláno jednou.)
			IsMouseVisible = true;
			_gdManager.ApplyChanges();
			base.Initialize();
		}

		protected override void LoadContent() {
			// Load textures/content (Načti textury/jiný obsah)
			base.LoadContent();
		}

		protected override void Update(GameTime gameTime) {
			// Update game logic/state (Akualizuj stav hry/herní logiky)
			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime) {
			GraphicsDevice.Clear(Color.Black);
			_renderer.Begin(blendState: BlendState.AlphaBlend);
			// Draw to the screen (Vykresli stav na obrazovku)
			_renderer.End();
			base.Draw(gameTime);
		}
	}
}
