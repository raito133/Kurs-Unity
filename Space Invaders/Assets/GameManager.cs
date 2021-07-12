using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] GameObject spaceShipPrefab;
    Vector3 shipStartingPosition = new Vector3 (0, -4, 0);
    int score = 0;

    private void Start()
    {
        Instantiate(spaceShipPrefab, shipStartingPosition, Quaternion.identity);
    }

    // Start is called before the first frame update
    public void IncreaseScore(int increment)
    {
        score += increment;
        text.text = score.ToString();
    }

    public void ResetGame()
    {
        // Resetowanie statku
        Instantiate(spaceShipPrefab, shipStartingPosition, Quaternion.identity);
        // Resetowanie kosmitów
        // Usuniêcie pocisków
    }
}
