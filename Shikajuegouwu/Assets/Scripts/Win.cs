using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject tablero;

    public GameObject[] spawnloc;
    void Start()
    {

    }
    void Update()
    {

    }
    public void SelectColumn(int column)
    {
        Debug.Log("Game Manager Column" + column);
        
    }
    public void TakeTurn(int column)
    {
        
        Instantiate(player1,spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
        
        Debug.Log("uwu");
    }

}
