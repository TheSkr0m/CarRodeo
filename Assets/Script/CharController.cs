using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharController : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    Rigidbody rigidbody;

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        rigidbody.AddForce(Vector3.up + Vector3.forward, ForceMode.Impulse);
    }

    void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        //rigidbody.velocity = Vector3.up + Vector3.forward * 10;
        rigidbody.AddForce(Vector3.up + Vector3.forward * 10, ForceMode.Impulse);

    }

    void Update () {
		
	}
}
