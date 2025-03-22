using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.UI;
using TMPro;

public class ClavarHacha : MonoBehaviour
{
    Rigidbody rb;

    AudioSource clavar;
    private Vector3 posicioninicial;
    private quaternion rotacioninicial;
    public Animator uianim;
    public Collider Edge;
    public AudioClip[] golpescuchillo;
    public AudioClip[] golpeshacha;
    public AudioClip[] golpessarten;
    public AudioClip acertado;
    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        clavar = transform.GetComponent<AudioSource>();
        posicioninicial = transform.position;
        rotacioninicial = transform.rotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        bool shouldSpawn = false;
        if (collision.gameObject.CompareTag("Diana"))
        {

            foreach (ContactPoint point in collision.contacts)
            {
                if (point.thisCollider == Edge)
                {
                    Debug.Log("Diana");
                    attachAxe(collision.gameObject.transform);
                    shouldSpawn = true;
                    
                }

            }
 
        }

        if (shouldSpawn)
        {
            Puntos.instance.IncreaseScore();
            StartCoroutine("TiempoRotura");

        }

        //colider soniddos//

        if (collision.gameObject.CompareTag("entorno"))
        {
            if (gameObject.CompareTag("Cuchillo"))
            {
                SonidosCuchillo();
            }
            else if (gameObject.CompareTag("hacha"))
            {
                SonidosHacha();
            }
            else if (gameObject.CompareTag("sarten"))
            {
                SonidosSarten();
            }
        }
    
}

    

    private void Respawn()
    {
        
       GameObject nuevo =  Instantiate(this.gameObject, posicioninicial, rotacioninicial);
        nuevo.GetComponent<Rigidbody>().isKinematic = false;
        nuevo.GetComponent<XRGrabInteractable>().enabled = true;

    }
    public void attachAxe(Transform objeto)
    {
        rb.isKinematic = true;
        clavar.PlayOneShot(acertado,0.8F);
        uianim.SetTrigger("X");
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.enabled = false;

    }

   IEnumerator TiempoRotura()
    {
        yield return new WaitForSeconds(3f);
        Respawn();
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);


    }
    
    public void SonidosCuchillo()
    {
        AudioClip clip = golpescuchillo[UnityEngine.Random.Range(0, golpescuchillo.Length)];
        clavar.PlayOneShot(clip, 0.4F);
    }
    public void SonidosHacha()
    {
        AudioClip clip = golpeshacha[UnityEngine.Random.Range(0, golpeshacha.Length)];
        clavar.PlayOneShot(clip, 0.7F);
    }
    public void SonidosSarten()
    {
        AudioClip clip = golpessarten[UnityEngine.Random.Range(0, golpessarten.Length)];
        clavar.PlayOneShot(clip, 0.4F);
    }
}
