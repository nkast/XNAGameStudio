#region File Description
//-----------------------------------------------------------------------------
// LoadingScreen.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements


using System;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Input;
#if WINDOWS_PHONE
using Microsoft.Phone.Shell;
#endif // if WINDOWS_PHONE


#endregion

namespace NinjAcademy
{
    class LoadingScreen : GameScreen
    {
        #region Fields


        Texture2D idleTexture;
        Texture2D busyTexture;

        Rectangle viewport;

        bool isLoading;
        GameplayScreen gameplayScreen;
#if WINDOWS_PHONE
        Thread thread;
#else
        System.Threading.Tasks.Task thread;
#endif //WINDOWS_PHONE


        #endregion

        #region Initialization


        /// <summary>
        /// Creates a new loading screen instance.
        /// </summary>
        /// <param name="idleTexture">Texture to display until the user taps the display.</param>
        /// <param name="busyTexture">Texture to display while loading the game assets.</param>
        public LoadingScreen(Texture2D idleTexture, Texture2D busyTexture)
        {
            this.idleTexture = idleTexture;
            this.busyTexture = busyTexture;

            TransitionOnTime = TimeSpan.FromSeconds(0);
            TransitionOffTime = TimeSpan.FromSeconds(0.5);

            EnabledGestures = GestureType.Tap;
        }

        /// <summary>
        /// Load the screen resources
        /// </summary>
        public override void LoadContent()
        {
            viewport = ScreenManager.GraphicsDevice.Viewport.Bounds;

            // Create a new instance of the gameplay screen
            gameplayScreen = new GameplayScreen();
            gameplayScreen.ScreenManager = ScreenManager;
        }


        #endregion

        #region Update


        /// <summary>
        /// Exit the screen after a tap gesture
        /// </summary>
        /// <param name="input"></param>
        public override void HandleInput(InputState input)
        {
            if (!isLoading)
            {
                PlayerIndex player;

                // Handle touch input
                if (input.Gestures.Count > 0)
                {
                    if (input.Gestures[0].GestureType == GestureType.Tap)
                    {
                        LoadResources();
                    }
                }
                else if (input.IsNewButtonPress(Buttons.Back, ControllingPlayer, out player))
                {
                    // Remove tombstoning data which we no longer need if returning to the main menu
#if WINDOWS_PHONE
                    if (PhoneApplicationService.Current.State.ContainsKey(NinjAcademyGame.GameStateKey))
                    {
                        PhoneApplicationService.Current.State.Remove(NinjAcademyGame.GameStateKey);
                    }
#endif // WINDOWS_PHONE

                    foreach (GameScreen screen in ScreenManager.GetScreens())
                    {
                        screen.ExitScreen();
                    }

                    ScreenManager.AddScreen(new BackgroundScreen("titlescreenBG"), null);
                    ScreenManager.AddScreen(new MainMenuScreen(), null);

                    AudioManager.PlayMusic("Menu Music");
                }                
            }

            base.HandleInput(input);
        }

        /// <summary>
        /// Screen update logic
        /// </summary>
        /// <param name="gameTime"></param>
        /// <param name="otherScreenHasFocus"></param>
        /// <param name="coveredByOtherScreen"></param>
        public override void Update(GameTime gameTime, bool otherScreenHasFocus, bool coveredByOtherScreen)
        {            
            // If additional thread is running, do nothing          
            if (null != thread)
            {
                // If additional thread finished loading and the screen is not exiting
#if WINDOWS_PHONE
                if (thread.ThreadState == ThreadState.Stopped && !IsExiting)
#else
                if (thread.IsCompleted && !IsExiting)
#endif // WINDOWS_PHONE
                {
                    // Move on to the countdown screen once high-score data is loaded                    
                    foreach (GameScreen screen in ScreenManager.GetScreens())
                    {
                        screen.ExitScreen();
                    }

                    ScreenManager.AddScreen(gameplayScreen, null);
                    ScreenManager.AddScreen(new CountdownScreen(gameplayScreen), null);
                }
            }

            base.Update(gameTime, otherScreenHasFocus, coveredByOtherScreen);
        }


        #endregion

        #region Render


        /// <summary>
        /// Render screen 
        /// </summary>
        /// <param name="gameTime"></param>
        public override void Draw(GameTime gameTime)
        {
            SpriteBatch spriteBatch = ScreenManager.SpriteBatch;

            spriteBatch.Begin();

            // If loading game play screen resource in the 
            // background, show "Loading..." text

            if (isLoading)
            {
                spriteBatch.Draw(busyTexture, viewport, Color.White * TransitionAlpha);
            }
            else
            {
                spriteBatch.Draw(idleTexture, viewport, Color.White * TransitionAlpha);                
            }

            spriteBatch.End();
        }


        #endregion

        #region Private functionality


        private void LoadResources()
        {
            // Start loading the resources in an additional thread
#if WINDOWS_PHONE
            thread = new Thread(new ThreadStart(gameplayScreen.LoadAssets));
            thread.Start();
#else
            thread = System.Threading.Tasks.Task.Run(()=> gameplayScreen.LoadAssets());
#endif //WINDOWS_PHONE

            isLoading = true;
        }


        #endregion
    }
}
