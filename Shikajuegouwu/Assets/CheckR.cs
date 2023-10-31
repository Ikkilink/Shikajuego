using UnityEngine;

public class CheckR : MonoBehaviour
{
    public float cronometro;

    CircleCollider2D circleCollider;

    void Start()
    {
        cronometro = 2;
        circleCollider = gameObject.GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        StartCheckR();
    }

    public void StartCheckR()
    {
        if (cronometro <= .2)
        {
            circleCollider.enabled = true;
        }
    }
}
