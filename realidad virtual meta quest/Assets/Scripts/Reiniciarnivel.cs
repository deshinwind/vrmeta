using UnityEngine;
using UnityEngine.SceneManagement;
public class Reiniciarnivel : MonoBehaviour
{

    Animator anim;


    private void Start()
    {
        anim = transform.GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Manos"))
        {
            anim.SetTrigger("pulsado");
            SceneManager.LoadScene("juego");
        }
        
    }
}
