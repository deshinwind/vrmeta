using UnityEngine;
using UnityEngine.UI;

public class Encestar : MonoBehaviour
{

    public int puntos;
    public Text marcador;
    public AudioSource encest;
   

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pbaloncesto"))
        {
            puntos++;
            encest.Play();
            marcador.text = puntos.ToString();
        }
    }


}
