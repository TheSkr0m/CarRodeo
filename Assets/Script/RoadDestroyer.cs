using UnityEngine;
using System.Collections;

public class RoadDestroyer : MonoBehaviour
{

    public RoadGenerator generator;
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("1" + other.tag);
        if (other.tag == "Road")
        {
            Debug.Log("2");
            generator.Rebuild(other.gameObject);
        }
        if (other.tag == "Car")
        {
            gameManager.RespawnCar(other.gameObject);
        }
    }


}
