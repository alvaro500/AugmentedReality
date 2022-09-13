using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action onMainMenu;
    public event Action onItemsMenu;
    public event Action onARPosition;

    public static GameManager instance;
    
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MainMenu();
    }

    public void MainMenu()
    {
        onMainMenu?.Invoke();//Constatar que existe que está suscrito a este evento.
        Debug.Log("Main Menu Activated");
    }

    public void ItemsMenu()
    {
        onItemsMenu?.Invoke();//Constatar que existe que está suscrito a este evento.
        Debug.Log("Items Menu Activated");
    }

    public void ARPosition()
    {
        onARPosition.Invoke();
        Debug.Log("AR position Activated");
    }

    public void CloseApp()
    {
        Application.Quit();
    }
}