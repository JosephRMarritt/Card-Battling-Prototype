using UnityEngine;
using UnityEngine.UI;

public class CharacterInstance : MonoBehaviour
{
    #region Variables

    public StatsInstance stats;
    public Slider _healthSlider;

    #endregion

    #region Initialization

    private void Start()
    {
        _healthSlider.minValue = 0;
        _healthSlider.maxValue = stats.MaxHealth;
        _healthSlider.value = stats.CurrentHealth;
    }

    #endregion

}
