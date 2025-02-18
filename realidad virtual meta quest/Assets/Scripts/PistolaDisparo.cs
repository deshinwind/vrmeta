using UnityEngine;

public class PistolaDisparo : MonoBehaviour
{

    public Transform spawnpoint;
    private Vector3 direccion = Vector3.forward;
    public float distancia;
    private void Update()
    {
        Physics.Raycast(spawnpoint.position, direccion, distancia);
    }


    private void OnDrawGizmos()
    {
        Debug.DrawRay(spawnpoint.position, direccion * distancia, Color.green);
        
    }
}
