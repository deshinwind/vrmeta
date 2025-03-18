using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject luz;
    public AudioSource click;
    
    public void Encender()
    {
        luz.SetActive(true);
        click.Play();
    }

    public void Apagar()
    {
        luz.SetActive(false);
        click.Play();
    }
}
