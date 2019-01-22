using UnityEngine;
using System.Collections;

public class RoadDestroyer : MonoBehaviour
{

    public RoadGenerator generator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Road")
        {
            generator.Rebuild(other.gameObject);
        }
    }


}
