using UnityEngine;

public abstract class CardCommand
{
    public abstract void Execute(TargettingBehaviour targetingBehaviour, int value, Effect effect);
}

public class CardSelectTargetCommand : CardCommand
{
    public override void Execute(TargettingBehaviour targetingBehaviour, int value, Effect effect)
    {
        Debug.Log("Select the target");
        Debug.Log("Play the card");
    }
}

public class CardPlayCommand : CardCommand
{
    public override void Execute(TargettingBehaviour targetingBehaviour, int value, Effect effect)
    {
       Debug.Log("Play the card");
    }
}

