using System.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.UI;
using TMPro;

public class ClavarHacha : MonoBehaviour
{
    Rigidbody rb;
   

    private Vector3 posicioninicial;
    private quaternion rotacioninicial;

    public Collider Edge;
    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
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
    
}
