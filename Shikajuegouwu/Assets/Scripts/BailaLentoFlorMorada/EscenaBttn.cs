using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EscenaBttn : MonoBehaviour
{
    public string finalDestiny;
    public void CambiarEscena()
    {
        SceneManager.LoadScene("finalDestiny");
        Debug.Log("Haz cambiado de escena con bttn");
    }
}