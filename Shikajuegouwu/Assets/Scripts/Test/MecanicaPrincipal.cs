using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaPrincipal : MonoBehaviour
{
    public GameObject tablero;
    public int angulo;
    public GameObject ficha;
    private Rigidbody2D ficharb;
    private bool isPressingLeft;
    // Start is called before the first frame update
    void Start()
    {
        angulo = 90;
        ficharb = ficha.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            isPressingLeft = true;
            StartCoroutine(Gaming());

        }
        if (Input.GetKeyDown("right"))
        {
            isPressingLeft = false;
            StartCoroutine(Gaming());

        }
        if (Input.GetKeyDown("space"))
        {
            isPressingLeft = false;
            StartCoroutine(Gaming180());

        }
    }

    public IEnumerator Gaming()
    {
        ficharb.bodyType = RigidbodyType2D.Kinematic;
        yield return new WaitForSeconds(0.01f);
        if (isPressingLeft)
        {
            tablero.transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }
        else
        {
            tablero.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }
        yield return new WaitForSeconds(0.01f);
        ficharb.bodyType = RigidbodyType2D.Dynamic;
    }
    public IEnumerator Gaming180()
    {
        ficharb.bodyType = RigidbodyType2D.Kinematic;
        yield return new WaitForSeconds(0.01f);
        tablero.transform.Rotate(0.0f, 0.0f, 180.0f, Space.Self);

        yield return new WaitForSeconds(0.01f);
        ficharb.bodyType = RigidbodyType2D.Dynamic;
    }
}
