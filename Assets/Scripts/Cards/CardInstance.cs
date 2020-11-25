using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardInstance : MonoBehaviour
{
    #region Variables

    // Data
    [Header("Data object")]
    public Card card;

    [Header("UI bindings")]
    [SerializeField]
    private TextMeshProUGUI cardTitleText;
    
    [SerializeField]
    private TextMeshProUGUI manaCostText;
    
    [SerializeField]
    private TextMeshProUGUI cardEffectText;

    [SerializeField] 
    private Image cardImage;

    #endregion

    
    #region Initialization

    private void Start()
    {
        cardTitleText.text = card.name;
        manaCostText.text = card.manaCost.ToString();
        cardEffectText.text = card.GetConflatedCommandDescription();
        cardImage.sprite = card.cardImage;
    }

    #endregion

    
    #region Touch Methods

    public void OnClick()
    {
        card.ExecuteCommands();
    }

    #endregion
}
