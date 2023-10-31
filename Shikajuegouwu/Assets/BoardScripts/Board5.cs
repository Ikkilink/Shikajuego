using UnityEngine;

public class Board5 : MonoBehaviour
{
    public bool rojo5 = false;
    public bool azul5 = false;

    [SerializeField] bool active = false;

    //private // spriteRenderer // spriteRenderer;

    void Start()
    {
        rojo5 = false;
        azul5 = false;

        // spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (rojo5 == false && azul5 == false)
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
            azul5 = true;
            rojo5 = false;
            active = true;
            // spriteRenderer.color = Color.blue;
        }

        if (collision.CompareTag("CheckR"))
        {
            azul5 = false;
            rojo5 = true;
            active = true;
            // spriteRenderer.color = Color.red;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckR"))
        {
            azul5 = false;
            rojo5 = false;
            active = true;
            ////soundEffects.PlaySlotSound();
        }
        if (collision.CompareTag("CheckA"))
        {
            azul5 = false;
            rojo5 = false;
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
