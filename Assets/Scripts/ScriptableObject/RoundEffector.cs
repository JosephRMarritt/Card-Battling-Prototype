using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RoundEffector", menuName = "ScriptableObjects/RoundEffector", order = 1)]
public class RoundEffector : ScriptableObject
{
    #region Variables

    public List<Command> commands;

    #endregion
}
