using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class CharController : MonoBehaviour
{
    public GameManager gameManager;
    public Player player;

    Rigidbody rigidbody;

    GameObject carRiding, car;
    public GameObject onAir;

  

    void Start () {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        GetCar();
    }

    public void Jump()
    {
        rigidbody.velocity = (Vector3.up + Vector3.forward) * 10;
        transform.SetParent(onAir.transform);
        gameManager.playerState = GameManager.PlayerState.inAir;
    }

    public void GetCar()
    {
        var overlap = Physics.OverlapSphere(transform.position, 5);
        var carCollider = overlap.FirstOrDefault(x => x.tag == "Car");
        if(carCollider != null)
        {
            //Debug.Log("Overleaped");
            car = carCollider.gameObject;
            if (car != null)
            {
                transform.SetParent(car.transform);
                transform.localPosition = new Vector3(0, 1, 0);
            }
        }
        gameManager.playerState = GameManager.PlayerState.onCar;
    }

    public void MoveCar(Vector2 pos)
    {
        Debug.Log(pos);
        car.transform.position = new Vector3(car.transform.position.x + pos.x * Time.deltaTime, car.transform.position.y, car.transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
