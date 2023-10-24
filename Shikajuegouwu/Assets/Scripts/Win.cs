using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject player1;//gameobject del primer jugador
    public GameObject player2;//gameobject del segundo jugador
    public GameObject tablero;//gameobject del tablero
    public bool player1turn = true;
    public GameObject[] spawnloc;// array de todos los spawns (son emptys)
    int[,] boardstate;
    public int heightofboard = 5;
    public int lenghtofboard = 5;
    void Start()
    {
        boardstate = new int[lenghtofboard, heightofboard];
    }
    public void SelectColumn(int column)
    {
        Debug.Log("Game Manager Column" + column); //esto es un debug que indica cuando le das click a una columna

    }
    public void TakeTurn(int column)
    {
        if(player1turn)
        {
            Instantiate(player1, spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
            //esto es un debug que indica cuando le das click a una columna aqui esta el spawn de las piezas
            Debug.Log("uwu");
            player1turn = false;
        }
        else
        {
            Instantiate(player2, spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
            player1turn = true;
        }
        
    }
    public void updateboard(int column)
    {
        for (int i = 0; i < heightofboard; i++)
        {
            if(boardstate[column, i] == 0)
            {
                if(player1turn)
                {
                    boardstate[column, i] = 1;
                }
                else 
                {
                    boardstate[column, i] = 2;
                }
            }
            Debug.Log("Pieza siendo spawneada en (" + column + " , " + i + ")");
        }
    }

}
