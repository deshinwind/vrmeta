using UnityEngine;
using UnityEngine.SceneManagement;
public class Reiniciarnivel : MonoBehaviour
{

    Animator anim;
    AudioSource aud;
    public string nombreescena;

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

    

    public void Cambioescenapornombre()
    {
        SceneManager.LoadScene(nombreescena);
    }
}
