using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text appleScore;

    public void SetAppleScore(int score)
    {
        appleScore.text = "Apples: " + score.ToString();
    }
}
