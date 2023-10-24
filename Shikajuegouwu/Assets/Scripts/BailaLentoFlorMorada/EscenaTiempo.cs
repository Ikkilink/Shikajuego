using UnityEngine;
using UnityEngine.SceneManagement;
public class EscenaTiempo : MonoBehaviour
{
    public string nombreDeLaEscenaDestino;
    public float tiempoDeEspera = 5.0f; 
    private void Start()
    {
        Invoke("CambiarEscena", tiempoDeEspera);
    }
    private void CambiarEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscenaDestino);
        Debug.Log("Haz cambiado de escena despues de un tiempo");
    }
}