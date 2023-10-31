using UnityEngine;

public class Board23 : MonoBehaviour
{
    public bool rojo23 = false;
    public bool azul23 = false;

    [SerializeField] bool active = false;

    //private // spriteRenderer // spriteRenderer;

    void Start()
    {
        rojo23 = false;
        azul23 = false;

        // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo23 == false && azul23 == false)
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
            azul23 = true;
            rojo23 = false;
            active = true;
            // spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("CheckR"))
        {
            azul23 = false;
            rojo23 = true;
            active = true;
            // spriteRenderer.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul23 = false;
            rojo23 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul23 = false;
            rojo23 = false;
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
