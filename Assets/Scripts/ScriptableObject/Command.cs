using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Command", menuName = "ScriptableObjects/Command", order = 1)]
public class Command : ScriptableObject, ICommand
{
    public TargettingBehaviour targetingBehaviour;
    public string description;
    public int value;
    public Effect effect;

    private CardCommand _cardCommand;
    
    public void Execute()
    {
        if (targetingBehaviour.targetType == TargetType.SelectableAnyone)
        {
            if (_cardCommand == null)
            {
                _cardCommand = new CardSelectTargetCommand();
            }
            
            _cardCommand.Execute(targetingBehaviour, value, effect);
        }
        else
        {
            if (_cardCommand == null)
            {
                _cardCommand = new CardPlayCommand();
            }
            
            _cardCommand.Execute(targetingBehaviour, value, effect);
        }
    }

    public void UnExecute()
    {

    }
}
