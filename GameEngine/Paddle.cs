using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  public class Paddle
  {
    static List<Paddle> paddles = new List<Paddle>();

    public float x = 0;
    public float y = 0;

    public KeyboardKey upKey;
    public KeyboardKey downKey;


    public Paddle(float x, float y, KeyboardKey upKey, KeyboardKey downKey)
    {
      paddles.Add(this);

      this.x = x;
      this.y = y;
      this.upKey = upKey;
      this.downKey = downKey;
    }

    public void Update()
    {
      if (Raylib.IsKeyDown(upKey))
      {
        y -= 0.2f;
      }
      else if (Raylib.IsKeyDown(downKey))
      {
        y += 0.2f;
      }
    }

    public void Draw()
    {
      Raylib.DrawRectangle((int)x, (int)y, 20, 50, Color.BLACK);
    }

    public static void DrawAll()
    {
      foreach (Paddle p in paddles)
      {
        p.Draw();
      }
    }

    public static void UpdateAll()
    {
      foreach (Paddle p in paddles)
      {
        p.Update();
      }
    }

  }
}
