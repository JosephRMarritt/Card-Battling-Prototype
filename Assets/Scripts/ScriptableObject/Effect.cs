using UnityEngine;

[CreateAssetMenu(fileName = "Effect", menuName = "ScriptableObjects/Effect", order = 1)]
public class Effect : ScriptableObject
{
    public EffectType effectType;
}