using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject player1;//gameobject del primer jugador
    public GameObject player2;//gameobject del segundo jugador
    public GameObject tablero;//gameobject del tablero
    public bool player1turn = true;

    public Text turnIndicator;
  
    public GameObject[] spawnloc;// array de todos los spawns (son emptys)
    public int heightofboard = 5;
    public int lenghtofboard = 5;
    int[,] boardstate;
    public BoxCollider2D[,] colliders;
    void Start()
    {
        boardstate = new int[lenghtofboard, heightofboard];
        UpdateTurnIndicator();
    }
   
    public void SelectColumn(int column)
    {
        Debug.Log("Game Manager Column" + column); //esto es un debug que indica cuando le das click a una columna
        TakeTurn(column);
    }
    public void TakeTurn(int column)
    {
           updateboard(column);
            if (player1turn)
            {
                //El guerrero Jaguar es el PL1 y el Aguila es el PL2
                Instantiate(player1, spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
                //esto es un debug que indica cuando le das click a una columna aqui esta el spawn de las piezas
                Debug.Log("uwu");
                player1turn = false;
                turnIndicator.text = ("Turno del Guerrero Aguila");
            
                /*if(didwin(1))
                {
                    Debug.Log("Guerrero Jaguar Gana");
                }
                if (didwin(2))
                {
                    Debug.Log("Guerrero Aguila Gana");
                }*/

            }
            else
            {
               Instantiate(player2, spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
               player1turn = true;
                turnIndicator.text = ("Turno del Guerrero Jaguar");
            }

            UpdateTurnIndicator();
        

        
        
    }

    private void UpdateTurnIndicator()
    {
        string playerTurn = player1turn ? "Guerrero Jaguar" : "Guerrero Aguila";
        turnIndicator.text = "Turno del " + playerTurn;
    }

    void updateboard(int column)
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
                //Debug.Log("Pieza siendo spawneada en (" + column + " , " + i + ")");
                
            }
            
        }
       
    }

   

    public void RestartGame()
    {
        // Reinicia todos los valores al estado inicial
        player1turn = true;
        turnIndicator.text = "Turno del Guerrero Jaguar";
        boardstate = new int[lenghtofboard, heightofboard];

        // Elimina todas las fichas del tablero
        foreach (Transform child in tablero.transform)
        {
            Destroy(child.gameObject);
        }

        // Vuelve a actualizar el indicador de turno
        UpdateTurnIndicator();
    }

}
