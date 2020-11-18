using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  public class Paddle: GameObject
  {
    
    
    public KeyboardKey upKey;
    public KeyboardKey downKey;


    public Paddle(float x, float y, KeyboardKey upKey, KeyboardKey downKey)
    {
      gameObjects.Add(this);

      this.rect.height = 50;
      this.rect.width = 20;
      this.rect.x = x;
      this.rect.y = y;

      this.upKey = upKey;
      this.downKey = downKey;
    }

    public override void Update()
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
  }
}
