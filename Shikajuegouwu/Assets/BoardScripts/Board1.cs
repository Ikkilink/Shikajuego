using UnityEngine;

public class Board1 : MonoBehaviour
{
    public bool rojo1 = false;
    public bool azul1 = false;

    [SerializeField] bool active = false;

    void Start()
    {
        rojo1 = false;
        azul1 = false;
    }

    private void Update()
    {
        if (rojo1 == false && azul1 == false)
        {
            active = false;
        }

        else
        {
            active = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Azul") && active == false)
        {
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
        }

        if (collision.CompareTag("CheckA"))
        {
            azul1 = true;
            rojo1 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }

        if (collision.CompareTag("CheckR"))
        {
            azul1 = false;
            rojo1 = true;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul1 = false;
            rojo1 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul1 = false;
            rojo1 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("Azul") && active == false)
        {
            //spriteRenderer.color = Color.white;
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
            //spriteRenderer.color = Color.white;
        }
    }
}
