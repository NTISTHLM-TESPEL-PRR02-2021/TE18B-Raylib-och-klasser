using System;
using Raylib_cs;

namespace GameEngine
{
  public class Ball
  {
    public Rectangle rect = new Rectangle(800 / 2 - 10, 600 / 2 - 10, 20, 20);

    float xMovement = 2f;
    float yMovement = 2f;

    public void Update()
    {
      rect.x += xMovement;
      rect.y += yMovement;

      for (int i = 0; i < Paddle.paddles.Count; i++)
      {
        if (Raylib.CheckCollisionRecs(rect, Paddle.paddles[i].rect))
        {
          xMovement = -xMovement;
        }
      }



      if (rect.y > 600 - rect.height || rect.y < 0)
      {
        yMovement = -yMovement;
      }

      if (rect.x > 800 - rect.width || rect.x < 0)
      {
        xMovement = -xMovement;
      }
    }

    public void Draw()
    {
      Raylib.DrawRectangleRec(rect, Color.BLACK);
    }

  }
}
