using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DispararAnimacion : MonoBehaviour
{
   
    private Animator animator;
    private bool yaActivado = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
     
        if (!yaActivado && collision.gameObject.name != "Plane")
        {
            
            yaActivado = true;
            animator.SetTrigger("Tocar");
        }
    }
}

