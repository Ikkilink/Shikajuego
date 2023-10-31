using UnityEngine;

public class CheckA : MonoBehaviour
{
    public float cronometro;

    CircleCollider2D circleCollider;

    void Awake()
    {
        cronometro = 2;
        circleCollider = gameObject.GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        StartCheckA();
    }

    public void StartCheckA()
    {
        if (cronometro <= .2)
        {
            circleCollider.enabled = true;
        }

        if (cronometro <= .1)
        {
            circleCollider.enabled = false;
        }
    }
}
