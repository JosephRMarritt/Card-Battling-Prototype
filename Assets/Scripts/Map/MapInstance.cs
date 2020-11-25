using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MapInstance : MonoBehaviour
{
    #region Variables

    // Data
    [SerializeField]
    private WorldMap _worldMap;

    [SerializeField]
    private Image worldMapImage;
    
    [SerializeField]
    private TextMeshProUGUI worldMapTitle;

    [SerializeField] 
    private GameObject battleNodePrefab;
    
    [SerializeField] 
    private GameObject battleNodeParent;
    
    #endregion
    
    
    #region Initialisation

    public void Start()
    {
        worldMapTitle.text = _worldMap.name;
        worldMapImage.sprite = _worldMap.worldMapSprite;
        worldMapImage.SetNativeSize();

        foreach (WorldNode worldNode in _worldMap.worldNodes)
        {
            GameObject worldNodeGameObject = Instantiate(battleNodePrefab, worldNode.position, Quaternion.identity, battleNodeParent.transform);
            
            WorldNodeInstance worldNodeInstance = worldNodeGameObject.GetComponent<WorldNodeInstance>();
            worldNodeInstance.Setup(worldNode);
        }
    }

    #endregion

}
