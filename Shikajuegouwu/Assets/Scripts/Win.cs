using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject player1;//gameobject del primer jugador
    public GameObject player2;//gameobject del segundo jugador
    public GameObject tablero;//gameobject del tablero

    public GameObject[] spawnloc;// array de todos los spawns (son emptys)
    void Start()
    {

    }
    void Update()
    {

    }
    public void SelectColumn(int column)
    {
        Debug.Log("Game Manager Column" + column); //esto es un debug que indica cuando le das click a una columna

    }
    public void TakeTurn(int column)
    {
        
        Instantiate(player1,spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
        //esto es un debug que indica cuando le das click a una columna aqui esta el spawn de las piezas
        Debug.Log("uwu");
    }

}
