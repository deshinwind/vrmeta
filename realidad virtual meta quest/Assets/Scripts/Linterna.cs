using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject luz;

    
    public void Encender()
    {
        luz.SetActive(true);
    }

    public void Apagar()
    {
        luz.SetActive(false);
    }
}
