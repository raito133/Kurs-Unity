using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject playerOnePaddle;
    [SerializeField] GameObject playerTwoPaddle;

    int playerOneScore = 0;
    int playerTwoScore = 0;

    public void IncreaseScore(bool isPlayerOne)
    {
        if(!isPlayerOne)
            playerOneScore++;
        else
            playerTwoScore++;
        Debug.Log(playerOneScore + " " + playerTwoScore);
    }





}
