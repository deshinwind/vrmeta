using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject luz;
    public AudioSource click;
    public AudioSource golpe;
    
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("entorno"))
        {
            golpe.Play();
        }
    }
}
