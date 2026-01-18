using SplashKitSDK;
using System;
using System.Numerics;
using System.Reflection;

namespace HideOut
{
    public class Program
    {
        public static void Main()
        {
            string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (!string.IsNullOrEmpty(exePath))
            {
                Directory.SetCurrentDirectory(exePath);
            }
            Window window = new Window("Hide Out", 1600, 960);
            DrawGameState drawGameState = new DrawGameState();
            //GameManager gameManager = new GameManager();
            //gameManager.SetUp();
            while (!window.CloseRequested) // Fix: Access CloseRequested as a property, not a method  
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(Color.Black);
                drawGameState.Draw();
                drawGameState.UpdateGameState();
                SplashKit.RefreshScreen(80);
                SplashKit.Delay(1000 / 80); // Ensure 60 FPS  
            }
        }
    }
}
