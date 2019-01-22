using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour {

    public GameObject prefab;
    public float roadPosition;
    public int startCount = 30;
    public float offset;
    List<GameObject> roadParts;

	// Use this for initialization
	void Start () {
        roadParts = new List<GameObject>();
        for (int i = 0; i < startCount; i++)
        {
            var road = Instantiate(prefab);
            road.transform.position = new Vector3(0, 0, offset*i);
           // roadPosition += 3;
            roadParts.Add(road);

        }
        roadPosition = startCount * offset;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Rebuild(GameObject road)
    {
        road.transform.position = new Vector3(0, 0, roadPosition + offset);
        roadPosition += offset;
    }
}
