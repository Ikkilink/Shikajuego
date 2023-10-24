using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject quitBtn;

    public void Quit ()
    {
        Debug.Log("Saliendo..");
        Application.Quit();
    }
}
