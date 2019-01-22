using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharController : MonoBehaviour
{
    public GameManager gameManager;

    Rigidbody rigidbody;
    

  

    void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();

    }

    public void Jump()
    {
        rigidbody.velocity = (Vector3.up + Vector3.forward) * 10;
    }

   
}
