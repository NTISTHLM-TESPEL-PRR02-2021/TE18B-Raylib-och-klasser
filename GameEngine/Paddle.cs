using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  public class Paddle
  {
    public static List<Paddle> paddles = new List<Paddle>();

    public Rectangle rect = new Rectangle();

    public KeyboardKey upKey;
    public KeyboardKey downKey;


    public Paddle(float x, float y, KeyboardKey upKey, KeyboardKey downKey)
    {
      paddles.Add(this);

      this.rect.height = 50;
      this.rect.width = 20;
      this.rect.x = x;
      this.rect.y = y;

      this.upKey = upKey;
      this.downKey = downKey;
    }

    public void Update()
    {
      if (Raylib.IsKeyDown(upKey))
      {
        this.rect.y -= 3f;
      }
      else if (Raylib.IsKeyDown(downKey))
      {
        this.rect.y += 3f;
      }
    }

    public void Draw()
    {
      Raylib.DrawRectangleRec(this.rect, Color.BLACK);
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
