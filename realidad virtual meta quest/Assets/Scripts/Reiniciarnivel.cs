using UnityEngine;
using UnityEngine.SceneManagement;
public class Reiniciarnivel : MonoBehaviour
{

    Animator anim;
    AudioSource aud;

    private void Start()
    {
        anim = transform.GetComponent<Animator>();
        aud = transform.GetComponent<AudioSource>();
    }

    public void Boton()
    {
        anim.SetTrigger("pulsado");
        aud.Play();
    }

    public void Cambio()
    {
        SceneManager.LoadScene("juego");
    }
}
