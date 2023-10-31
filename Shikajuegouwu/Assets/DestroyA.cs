using UnityEngine;

public class DestroyA : MonoBehaviour
{
    public CheckA checkA;

    private void Awake()
    {
        checkA = FindFirstObjectByType<CheckA>();
    }

    private void Update()
    {
        if (checkA.cronometro <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
