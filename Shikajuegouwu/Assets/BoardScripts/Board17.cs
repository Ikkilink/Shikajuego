using UnityEngine;

public class Board17 : MonoBehaviour
{
    public bool rojo17 = false;
    public bool azul17 = false;

    [SerializeField] bool active = false;

    //private // spriteRenderer // spriteRenderer;

    void Start()
    {
        rojo17 = false;
        azul17 = false;

        // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo17 == false && azul17 == false)
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
            azul17 = true;
            rojo17 = false;
            active = true;
            // spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("CheckR"))
        {
            azul17 = false;
            rojo17 = true;
            active = true;
            // spriteRenderer.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul17 = false;
            rojo17 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul17 = false;
            rojo17 = false;
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
