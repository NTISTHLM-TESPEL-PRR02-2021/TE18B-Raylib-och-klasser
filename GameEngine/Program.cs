using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using Raylib_cs;

namespace GameEngine
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "Spelmotor demo");

      Paddle leftPaddle = new Paddle(10, 300, KeyboardKey.KEY_W, KeyboardKey.KEY_S);
      Paddle rightPaddle = new Paddle(770, 300, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);

      while (!Raylib.WindowShouldClose())
      {

        Paddle.UpdateAll();

        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.GOLD);

        Paddle.DrawAll();

        Raylib.EndDrawing();

      }

      
    }
  }
}
