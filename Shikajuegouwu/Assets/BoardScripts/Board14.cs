using UnityEngine;

public class Board14 : MonoBehaviour
{
    public bool rojo14 = false;
    public bool azul14 = false;

    [SerializeField] bool active = false;

    //private // spriteRenderer // spriteRenderer;

    void Start()
    {
        rojo14 = false;
        azul14 = false;

        // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo14 == false && azul14 == false)
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
            azul14 = true;
            rojo14 = false;
            active = true;
            // spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("CheckR"))
        {
            azul14 = false;
            rojo14 = true;
            active = true;
            // spriteRenderer.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul14 = false;
            rojo14 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul14 = false;
            rojo14 = false;
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
