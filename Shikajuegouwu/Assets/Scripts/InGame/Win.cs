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
        if(updateboard(column))
        {
            if (player1turn)
            {
                //El guerrero Jaguar es el PL1 y el Aguila es el PL2
                Instantiate(player1, spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
                //esto es un debug que indica cuando le das click a una columna aqui esta el spawn de las piezas
                Debug.Log("uwu");
                player1turn = false;
                turnIndicator.text = ("Turno del Guerrero Aguila");
            
                if(didwin(1))
                {
                    Debug.Log("Guerrero Jaguar Gana");
                }
              
            }
            else
            {
               Instantiate(player2, spawnloc[column].transform.position, Quaternion.identity, tablero.transform);
               player1turn = true;
                turnIndicator.text = ("Turno del Guerrero Jaguar");
            }

            UpdateTurnIndicator();
        }

        
        
    }

    private void UpdateTurnIndicator()
    {
        string playerTurn = player1turn ? "Guerrero Jaguar" : "Guerrero Aguila";
        turnIndicator.text = "Turno del " + playerTurn;
    }

    bool updateboard(int column)
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
                Debug.Log("Pieza siendo spawneada en (" + column + " , " + i + ")");
                return true;
            }
            
        }
        return false;
    }

    bool didwin(int playerNum)
    {
        //Horizontal
       for(int i = 0; i < lenghtofboard; i++)
        {
            for (int x = 0; x < lenghtofboard; x++)
            {
                if (boardstate[i, x] == playerNum && boardstate[i + 1, x] == playerNum && boardstate[i+2,x]==playerNum&& boardstate[i+3,x] == playerNum && boardstate[i + 4, x] == playerNum)
                {
                    if (playerNum == 1)
                    {
                        SceneManager.LoadScene("Ganador1");
                    }
                    else if (playerNum == 2)
                    {
                        SceneManager.LoadScene("Ganador2");
                    }
                    return true;
                }
            }
        }
       //Vertical
       for(int i = 0; i<lenghtofboard; i++)
        {
            for (int x = 0; x < heightofboard; x++)
            {
                if (boardstate[i, x] == playerNum && boardstate[i, x +1] == playerNum && boardstate[i, x+2] == playerNum && boardstate[i,x+3] == playerNum && boardstate[i + 4, x] == playerNum)
                {
                    if (playerNum == 1)
                    {
                        SceneManager.LoadScene("Ganador1");
                    }
                    else if (playerNum == 2)
                    {
                        SceneManager.LoadScene("Ganador2");
                    }
                    return true;
                }
            }
        }
       //Diagonales
        for (int i = 0; i < lenghtofboard-3; i++)
        {
            for (int x = 0; x < heightofboard -3; x++)
            {
                if (boardstate[i, x] == playerNum && boardstate[i + 1, x + 1] == playerNum && boardstate[i +2, x + 2] == playerNum && boardstate[i+3, x + 3] == playerNum && boardstate[i + 4, x] == playerNum)
                {
                    if (playerNum == 1)
                    {
                        SceneManager.LoadScene("Ganador1");
                    }
                    else if (playerNum == 2)
                    {
                        SceneManager.LoadScene("Ganador2");
                    }
                    return true;
                }
            }
        }

        return false;
    }
}
