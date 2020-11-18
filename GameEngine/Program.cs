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
      Raylib.SetTargetFPS(60);

      Paddle leftPaddle = new Paddle(10, 300, KeyboardKey.KEY_W, KeyboardKey.KEY_S);
      Paddle rightPaddle = new Paddle(770, 300, KeyboardKey.KEY_UP, KeyboardKey.KEY_DOWN);

      Ball ball = new Ball();

      while (!Raylib.WindowShouldClose())
      {

        GameObject.UpdateAll();

        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.GOLD);

        GameObject.DrawAll();

        Raylib.EndDrawing();

      }

      
    }
  }
}
