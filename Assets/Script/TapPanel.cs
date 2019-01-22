using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TapPanel : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler 
{
    public GameManager gameManager;
    public CharController charController;



    void Start () {
		
	}
	
	void Update () {
		
	}

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        switch (gameManager.playerState)
        {
            case GameManager.PlayerState.isWaiting:
                break;
            case GameManager.PlayerState.onCar:
                charController.MoveCar(eventData.delta);
                break;
            case GameManager.PlayerState.inAir:
                break;
            default:
                break;
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnDown");
        //switch (gameManager.playerState)
        //{
        //    case GameManager.PlayerState.isWaiting:
        //        gameManager.StartGame();
        //        break;
        //    case GameManager.PlayerState.onCar:
        //        break;
        //    case GameManager.PlayerState.inAir:
        //        break;
        //    default:
        //        break;
        //}

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("OnUp");
        switch (gameManager.playerState)
        {
            case GameManager.PlayerState.isWaiting:
                gameManager.StartGame();

                break;
            case GameManager.PlayerState.onCar:
                charController.Jump();

                break;
            case GameManager.PlayerState.inAir:
                charController.GetCar();

                break;
            default:
                break;
        }
    }
}
