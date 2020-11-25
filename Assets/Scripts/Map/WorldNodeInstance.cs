using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WorldNodeInstance : MonoBehaviour
{
    #region Variables
    
    private WorldNode _worldNode;

    [SerializeField]
    private Image _worldNodeImage;
    
    [SerializeField]
    private TextMeshProUGUI _worldNodeId;

    #endregion


    #region Initialization

    public void Setup(WorldNode worldNode)
    {
        _worldNode = worldNode;

        _worldNodeImage.sprite = worldNode.worldNodeSprite;
        _worldNodeId.text = worldNode.levelSelectOrder.ToString();
    }

    #endregion
}
