using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject
{
    #region Variables

    public string name;
    public GameObject prefab;
    public Sprite characterPortrait; 
    public Stats stats;
    public CharacterType characterType;

    public Card[] abilityCards;
    public RoundEffector roundEffector;

    #endregion
}

