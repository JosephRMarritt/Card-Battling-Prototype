using UnityEngine;

public class BattleInstance : MonoBehaviour
{
    #region Variables

    // Data
    private Battle _battle;

    private CharacterTransform[] opponentTransforms;
    private CharacterTransform[] playerTransforms;

    public class CharacterTransform
    {
        public Transform characterTransform;
        public CharacterInstance characterInstance;
    }

    #endregion


    #region Initialization

    public void Setup(Battle battle)
    {
        _battle = battle;
    }

    #endregion


    #region Card Events

    public void CardSelected(CardInstance cardInstance)
    {
        
    }

    public void CardDeselected(CardInstance cardInstance)
    {
        
    }

    #endregion
    


    #region Battle Events

    public void BattleStart()
    {

    }

    public void BattleEnd()
    {

    }

    #endregion


    #region Round Events

    public void RoundStart()
    {

    }

    public void RoundEnd()
    {
        
    }

    #endregion


    #region Turn Events

    public void TurnStart()
    {
        
    }

    public void TurnEnd()
    {
        
    }

    #endregion

    
    #region On Death

    public void OnDeath(CharacterInstance characterInstance)
    {
        
    }

    #endregion

}
