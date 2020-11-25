using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour
{
    #region Vars

    // Bottom buttons
    [SerializeField] private Button _manaButton;
    [SerializeField] private Button _drawPileButton;
    [SerializeField] private Button _discardPileButton;
    [SerializeField] private Button _endTurnButton;
    
    // Not sure what to do with this yet, it should be dynamically loaded
    [SerializeField] private CardInstance[] _cardButtons;
    
    // Top buttons
    [SerializeField] private Button _roundEffectorButton;
    [SerializeField] private Button _settingsButton;

    #endregion
    
    
    #region Initialise

    public void Start()
    {
        // Bottom buttons
        _manaButton.onClick.AddListener(ManaPressedHandler);
        _drawPileButton.onClick.AddListener(DrawPilePressedHandler);
        _discardPileButton.onClick.AddListener(DiscardPilePressedHandler);
        _endTurnButton.onClick.AddListener(EndTurnPressedHandler);
        
        // Card buttons
        for (int i = 0; i < _cardButtons.Length; i++)
        {
            var index = i;
            _cardButtons[i].GetComponent<Button>().onClick.AddListener(delegate { CardPressedHandler(_cardButtons[index]); });
        }
        
        
        // Top buttons
        _roundEffectorButton.onClick.AddListener(RoundEffectorPressedHandler);
        _settingsButton.onClick.AddListener(SettingsPressedHandler);
    }

    #endregion

    
    #region Handlers

    public void ManaPressedHandler()
    {
        Debug.Log("Mana button pressed");
    }

    public void DrawPilePressedHandler()
    {
        Debug.Log("Draw pile button pressed");
    }

    public void CardPressedHandler(CardInstance cardInstance)
    {
        Debug.Log($"Card {cardInstance.card.name} pressed");
        cardInstance.OnClick();
    }

    public void DiscardPilePressedHandler()
    {
        Debug.Log("Discard Pile button pressed");
    }

    public void EndTurnPressedHandler()
    {
        Debug.Log("End Turn button pressed");
    }

    public void RoundEffectorPressedHandler()
    {
        Debug.Log("Round Effector button pressed");
    }

    public void SettingsPressedHandler()
    {
        Debug.Log("Settings button pressed");
    }

    #endregion
}
