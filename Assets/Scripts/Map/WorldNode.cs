using System;
using UnityEngine;

[Serializable]
public class WorldNode
{
    public string name;
    public int levelSelectOrder;
    public Sprite worldNodeSprite;
    public Vector2 position;
    public Battle battle;
}