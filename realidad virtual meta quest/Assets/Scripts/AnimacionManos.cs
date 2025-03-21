using System;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.InputSystem;
public class AnimacionManos : MonoBehaviour
{
    public InputActionProperty grip;

    Animator anim;

    private void Start()
    {
        anim = transform.GetComponent<Animator>();
    }
    private void Update()
    {
        float gripvalue = grip.action.ReadValue<float>();
        anim.SetFloat("Grip", gripvalue);
    }
}
