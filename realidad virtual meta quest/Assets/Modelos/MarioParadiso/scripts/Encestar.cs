using UnityEngine;
using UnityEngine.UI;

public class Encestar : MonoBehaviour
{

    public int puntos;
    public Text marcador;

   

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Pbaloncesto"))
        {
            puntos++;
            marcador.text = puntos.ToString();
        }
    }


}
