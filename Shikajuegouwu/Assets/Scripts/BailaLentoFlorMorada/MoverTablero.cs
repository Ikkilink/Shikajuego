using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverTablero : MonoBehaviour
{
    public GameObject ficha;
    public GameObject tablero;
    private bool tableroRotating = false;
    private int tableroRotationAngle = 0;

    void Update()
    {
        if (!tableroRotating)
        {
            // Mover la ficha con las teclas direccionales, A y D
            float moveSpeed = 5.0f;
            float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
            ficha.transform.Translate(new Vector3(moveX, 0, moveY));

            // Tirar la ficha en el tablero con la barra espaciadora
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Coloca la ficha en el tablero o realiza alguna acción relacionada con esto.
            }
        }

        // Rotar el tablero
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(RotateTablero());
        }
    }

    IEnumerator RotateTablero()
    {
        if (tableroRotationAngle == 0)
        {
            tableroRotating = true;
            tableroRotationAngle = 90;
            tablero.transform.Rotate(Vector3.up, tableroRotationAngle);
            yield return new WaitForSeconds(0.2f);
            tableroRotating = false;
        }
        else if (tableroRotationAngle == 90)
        {
            tableroRotating = true;
            tableroRotationAngle = -90;
            tablero.transform.Rotate(Vector3.up, tableroRotationAngle);
            yield return new WaitForSeconds(0.2f);
            tableroRotating = false;
        }
        else if (tableroRotationAngle == -90)
        {
            tableroRotating = true;
            tableroRotationAngle = 180;
            tablero.transform.Rotate(Vector3.up, tableroRotationAngle);
            yield return new WaitForSeconds(0.2f);
            tableroRotating = false;
        }
        else if (tableroRotationAngle == 180)
        {
            tableroRotating = true;
            tableroRotationAngle = 0;
            tablero.transform.Rotate(Vector3.up, tableroRotationAngle);
            yield return new WaitForSeconds(0.2f);
            tableroRotating = false;
        }
    }
}
