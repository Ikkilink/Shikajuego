using UnityEngine;

public class Board2 : MonoBehaviour
{
    public bool rojo2 = false;
    public bool azul2 = false;

    [SerializeField] bool active = false;

    //private // spriteRenderer // spriteRenderer;
    //public //soundEffects //soundEffects;

    void Start()
    {
        rojo2 = false;
        azul2 = false;

        // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo2 == false && azul2 == false)
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
            // spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
            // spriteRenderer.color = Color.red;
        }

        if (collision.CompareTag("CheckA"))
        {
            azul2 = true;
            rojo2 = false;
            active = true;
            // spriteRenderer.color = Color.blue;
            //soundEffects.PlaySlotSound();
        }

        if (collision.CompareTag("CheckR"))
        {
            azul2 = false;
            rojo2 = true;
            active = true;
            // spriteRenderer.color = Color.red;
            //soundEffects.PlaySlotSound();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul2 = false;
            rojo2 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul2 = false;
            rojo2 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("Azul") && active == false)
        {
            // spriteRenderer.color = Color.white;
        }

        if (collision.CompareTag("Rojo") && active == false)
        {
            // spriteRenderer.color = Color.white;
        }
    }
}
