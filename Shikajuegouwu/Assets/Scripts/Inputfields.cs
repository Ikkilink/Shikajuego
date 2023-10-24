using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputfields : MonoBehaviour
{
    public int column;//numero de columna/identificador de columna
    public Win gm;//manda a llamar el script y las funciones de Win

    void OnMouseDown()
    {
        gm.SelectColumn(column);//manda a llamar debug
        //gm.TakeTurn(column);//manda a llamar el spawn
        //gm.updateboard(column);
    }

}
