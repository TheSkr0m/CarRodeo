using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GameManager : MonoBehaviour {
    public enum PlayerState
    {
        isWaiting,
        onCar,
        inAir
    }

    public Player player;
    public PlayerState playerState;
    public List<GameObject> cars, usedCars;

    public int startCarsAmount, spawnOffset = 25;
    public GameObject character;




    void Start()
    {
        playerState = PlayerState.isWaiting;
        var Car = GameObject.Find("cars");
        Debug.Log(Car.transform.childCount);
        for (int i = 0; i < Car.transform.childCount; i++)
        {
            cars.Add(Car.transform.GetChild(i).gameObject);
            cars[i].SetActive(false);
        }
        SetStartCar();
    }

    private void Update ()
    {
		
	}

    public void RespawnCar(GameObject carHit)
    {
        cars.Add(carHit);
        usedCars.Remove(carHit);
        SetPosition(cars.LastOrDefault().transform);
    }

    private void SetPosition(Transform carPosition)
    {
        if (usedCars.Count > 0)
        {
            var z = usedCars.LastOrDefault().transform.position.z;
            carPosition.position = new Vector3(Random.Range(-5f, 5f), carPosition.position.y, z + spawnOffset);
        }
    }

    private void SetStartCar()
    {
        character.SetActive(true);
        for (int i = 0; i < startCarsAmount; i++)
        {
            usedCars.Add(cars[i]);
            usedCars[i].SetActive(true);
            cars.RemoveAt(i);

            if (usedCars.Count > 0)
            {
                var z = usedCars.LastOrDefault().transform.position.z;
                usedCars[i].transform.position = new Vector3(Random.Range(-5f, 5f), usedCars[i].transform.position.y, z + spawnOffset);
            }
        }
        character.transform.SetParent(usedCars[0].transform);
        character.transform.localPosition = new Vector3(0, 1, 0);


    }

    public void StartGame()
    {
        playerState = PlayerState.onCar;

    }
}
