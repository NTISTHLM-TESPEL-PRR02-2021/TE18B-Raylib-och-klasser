using System;
using System.Collections.Generic;
using Raylib_cs;

namespace GameEngine
{
  public class GameObject
  {
    public Rectangle rect = new Rectangle();

    public static List<GameObject> gameObjects = new List<GameObject>();

    public GameObject()
    {
      gameObjects.Add(this);
    }

    public void Draw()
    {
      Raylib.DrawRectangleRec(rect, Color.BLACK);
    }

    public static void DrawAll()
    {
      foreach (GameObject p in gameObjects)
      {
        p.Draw();
      }
    }

    public virtual void Update()
    {

    }

    public static void UpdateAll()
    {
      foreach (GameObject p in gameObjects)
      {
        p.Update();
      }
    }

  }
}
