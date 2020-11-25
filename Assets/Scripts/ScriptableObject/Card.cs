using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Card", order = 1)]
public class Card : ScriptableObject
{
    #region Variables

    public string name;
    public Sprite cardImage;
    public int manaCost;
    public Character cardOwner;

    public List<Command> commands;
   
    #endregion

    #region Behaviour

    public void ExecuteCommands()
    {
        for (int i = 0; i < commands.Count; i++)
        {
            commands[i].Execute();
        }
    }

    #endregion

    
    #region Helper Methods

    public string GetConflatedCommandDescription()
    {
        string value = ""; 
        
        for (int i = 0; i < commands.Count; i++)
        {
            value += commands[i].description;
        }

        return value;
    }

    #endregion
}


