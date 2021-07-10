using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject playerOnePaddle;
    [SerializeField] GameObject playerTwoPaddle;
    [SerializeField] Text playerOneScoreText;
    [SerializeField] Text playerTwoScoreText;

    int playerOneScore = 0;
    int playerTwoScore = 0;

    public void IncreaseScore(bool isPlayerOne)
    {
        if(!isPlayerOne)
            playerOneScore++;
        else
            playerTwoScore++;

        playerOneScoreText.text = playerOneScore.ToString();
        playerTwoScoreText.text = playerTwoScore.ToString();

        Debug.Log(playerOneScore + " " + playerTwoScore);
        playerOnePaddle.GetComponent<Paddle>().ResetPosition();
        playerTwoPaddle.GetComponent<Paddle>().ResetPosition();
    }





}
