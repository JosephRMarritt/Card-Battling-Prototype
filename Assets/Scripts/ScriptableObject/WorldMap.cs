using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WorldMap", menuName = "ScriptableObjects/WorldMap", order = 1)]
public class WorldMap : ScriptableObject
{
    public string name;
    public Sprite worldMapSprite;
    public List<WorldNode> worldNodes;
}
