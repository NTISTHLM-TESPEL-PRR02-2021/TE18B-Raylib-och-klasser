using System;
using Raylib_cs;

namespace GameEngine
{
  public class Ball: GameObject
  {
    float xMovement = 2f;
    float yMovement = 2f;

    public Ball()
    {
      rect.width = 20;
      rect.height = 20;

      gameObjects.Add(this);
    }

    public override void Update()
    {
      rect.x += xMovement;
      rect.y += yMovement;

      for (int i = 0; i < Paddle.gameObjects.Count; i++)
      {
        if (Raylib.CheckCollisionRecs(rect, Paddle.gameObjects[i].rect))
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
  }
}
