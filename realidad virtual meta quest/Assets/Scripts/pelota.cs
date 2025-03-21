using UnityEngine;

public class pelota : MonoBehaviour
{
    public AudioSource bola;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("entorno"))
        {
            bola.Play();
        }
    }
}
