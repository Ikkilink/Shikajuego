using UnityEngine;

public class Board13 : MonoBehaviour
{
    public bool rojo13 = false;
    public bool azul13 = false;

    [SerializeField] bool active = false;

    //private // spriteRenderer // spriteRenderer;

    void Start()
    {
        rojo13 = false;
        azul13 = false;

        // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo13 == false && azul13 == false)
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
            azul13 = true;
            rojo13 = false;
            active = true;
            // spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("CheckR"))
        {
            azul13 = false;
            rojo13 = true;
            active = true;
            // spriteRenderer.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul13 = false;
            rojo13 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul13 = false;
            rojo13 = false;
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
