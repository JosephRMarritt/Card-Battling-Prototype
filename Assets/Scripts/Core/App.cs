using System;
using UnityEngine;

public class App : MonoBehaviour
{
    #region Variables

    public EventsController eventsController;

    #endregion

    #region Initialization

    public void Awake()
    {
        CreateControllers();
    }

    private void CreateControllers()
    {
        
    }

    #endregion
}
