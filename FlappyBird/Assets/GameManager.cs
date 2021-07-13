using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] 
    Text text;

    public void SetScore(int score)
    {
        text.text = "Score: " + score.ToString();
    }
}
