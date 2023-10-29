using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { gameObject.transform.Rotate(0, 0, 90); }
        if (Input.GetKeyDown(KeyCode.RightArrow)) { gameObject.transform.Rotate(0, 0, -90); }
        if (Input.GetKeyDown(KeyCode.Space)) { gameObject.transform.Rotate(0, 0, 180); }
        //movimiento del tablero al presionar teclas xd
    }
}

