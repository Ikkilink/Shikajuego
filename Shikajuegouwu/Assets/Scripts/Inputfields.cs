using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputfields : MonoBehaviour
{
    public int column;
    public Win gm;

    void OnMouseDown()
    {
        gm.SelectColumn(column);
        gm.TakeTurn(column);
    }

}
