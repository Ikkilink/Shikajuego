using UnityEngine;

public class Board3 : MonoBehaviour
{
    public bool rojo3 = false;
    public bool azul3 = false;

    [SerializeField] bool active = false;

    //private // spriteRenderer // spriteRenderer;
    //public //soundEffects //soundEffects;

    void Start()
    {
        rojo3 = false;
        azul3 = false;

        // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo3 == false && azul3 == false)
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
            azul3 = true;
            rojo3 = false;
            active = true;
            // spriteRenderer.color = Color.blue;
            //soundEffects.PlaySlotSound();
        }

        if (collision.CompareTag("CheckR"))
        {
            azul3 = false;
            rojo3 = true;
            active = true;
            // spriteRenderer.color = Color.red;
            //soundEffects.PlaySlotSound();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul3 = false;
            rojo3 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul3 = false;
            rojo3 = false;
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
