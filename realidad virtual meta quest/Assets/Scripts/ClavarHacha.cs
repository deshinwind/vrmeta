using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ClavarHacha : MonoBehaviour
{
    Rigidbody rb;
    

    public Collider Edge;
    private void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Diana"))
        {

            foreach (ContactPoint point in collision.contacts)
            {
                if (point.thisCollider == Edge)
                {
                    Debug.Log("Diana");
                    attachAxe(collision.gameObject.transform);
                }

            }
           

          
        }
    }

    public void attachAxe(Transform objeto)
    {
        rb.isKinematic = true;
        
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.enabled = false; 
        
    }

   

}
