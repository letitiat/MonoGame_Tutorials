﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tutorial020.Sprites
{
  public class Sprite : Component, ICloneable
  {
    protected float _rotation;

    protected Texture2D _texture;

    public List<Sprite> Children { get; set; }

    public Color Colour { get; set; }

    public bool IsRemoved { get; set; }

    public float Layer { get; set; }

    public Vector2 Origin
    {
      get
      {
        return new Vector2(_texture.Width / 2, _texture.Height / 2);
      }
    }

    public Vector2 Position { get; set; }

    public Rectangle Rectangle
    {
      get
      {
        return new Rectangle((int)Position.X - (int)Origin.X, (int)Position.Y - (int)Origin.Y, _texture.Width, _texture.Height);
      }
    }

    public Sprite Parent;

    public Sprite(Texture2D texture)
    {
      _texture = texture;

      Children = new List<Sprite>();

      Colour = Color.White;
    }

    public override void Update(GameTime gameTime)
    {

    }

    public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
    {
      spriteBatch.Draw(_texture, Position, null, Colour, _rotation, Origin, 1f, SpriteEffects.None, Layer);
    }

    public object Clone()
    {
      return this.MemberwiseClone();
    }
  }
}
