using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.AssetImporters;
using UnityEngine;

[CreateAssetMenu(fileName = "Battle", menuName = "ScriptableObjects/Battle", order = 1)]
public class Battle : ScriptableObject
{
    #region Variables
    
    public Arena arena;
    public Character[] players;
    public Character[] opponents;

    #endregion
}
