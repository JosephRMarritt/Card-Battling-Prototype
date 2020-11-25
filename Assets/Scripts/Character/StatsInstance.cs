using System;
using UnityEngine;

public class StatsInstance : MonoBehaviour
{
    #region Variables
    
    private int _maxHealth = 10;
    private int _currentHealth;
    private bool _isDead;

    public GameEvent OnDeath;
    
    #endregion

    
    #region Initialization

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }
    
    #endregion


    #region Properties

    public int CurrentHealth
    {
        get => _currentHealth;
        set
        {
            _currentHealth = value;
            
            if (_currentHealth <= 0 && _isDead)
            {
                _currentHealth = 0;
                _isDead = true;
                
                OnDeath.Raise();
            }
        }
    }

    public int MaxHealth
    {
        get => _maxHealth;
    }

    #endregion

    
    #region Stat Manipulation


    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
    }

    #endregion

}
