using UnityEngine;

public class DestroyR : MonoBehaviour
{
    CheckR checkR;

    void Start()
    {
        checkR = FindObjectOfType<CheckR>();
    }

    void Update()
    {
        if (checkR.cronometro <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
