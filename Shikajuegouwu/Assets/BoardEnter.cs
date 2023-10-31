using UnityEngine;
using UnityEngine.UIElements;

public class BoardEnter : MonoBehaviour
{
    public bool Entro;
    public bool EntroR;

    CheckA checkA;
    CheckR checkR;

    public GameObject FichaA;
    public Vector3 Position;
    public Quaternion Rotation;
    public Transform Parent;

    public GameObject FichaR;
    public Vector3 PositionR;
    public Quaternion RotationR;
    public Transform ParentR;

    void Start()
    {
        Entro = false;
        EntroR = false;

        checkA = FindObjectOfType<CheckA>();
        checkR = FindObjectOfType<CheckR>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul"))
        {
            Entro = true;

            checkA = FindObjectOfType<CheckA>();
        }

        if (collision.CompareTag("Rojo"))
        {
            EntroR = true;
            checkR = FindObjectOfType<CheckR>();
        }
    }

    void Update()
    {
        if (Entro == true || offCheck.outA)
        {
            checkA.cronometro -= Time.deltaTime;

            while (checkA.cronometro < -.15)
            {
                checkA.cronometro = 2;
                Entro = false;
                offCheck.outA = false;
                Instantiate(FichaA, Position, Rotation, Parent);
                checkA = FindObjectOfType<CheckA>();
                break;
            }
        }

        if (EntroR == true || offCheck.outR)
        {
            checkR.cronometro -= Time.deltaTime;

            while (checkR.cronometro < -.5)
            {
                checkR.cronometro = 2;
                EntroR = false;
                offCheck.outR = false;
                Instantiate(FichaR, PositionR, RotationR, ParentR);
                checkR = FindObjectOfType<CheckR>();
                break;
            }
        }
    }
}
