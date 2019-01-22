using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public enum PlayerState
    {
        isWaiting,
        onCar,
        inAir
    }

    public PlayerState playerState;

    void Start()
    {
        playerState = PlayerState.isWaiting;

    }

    void Update () {
		
	}
    public void StartGame()
    {
        playerState = PlayerState.onCar;

    }
}
