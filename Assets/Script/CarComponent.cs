using UnityEngine;
using System.Collections;

public class CarComponent : MonoBehaviour
{
    private float speed;
    private int price;

    // Use this for initialization
    void Start()
    {
        speed = Random.Range(1f, 10f);
        price = Random.Range(1, 100);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

    }

    public int GetPrice()
    {
        return price;
    }
}
