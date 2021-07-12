using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] GameObject spaceShipPrefab;
    [SerializeField] Transform shipStartingPosition;
    [SerializeField] AlienSpawner alienSpawner;
    int score = 0;

    private void Start()
    {
        Instantiate(spaceShipPrefab, shipStartingPosition.position, Quaternion.identity);
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
        Instantiate(spaceShipPrefab, shipStartingPosition.position, Quaternion.identity);
        // Resetowanie kosmitów
        alienSpawner.DestroyAliens();
        alienSpawner.SpawnAliens();
        // Usuniêcie pocisków
        foreach(GameObject bullet in GameObject.FindGameObjectsWithTag("Bullet"))
        {
            Destroy(bullet);
        }
    }
}
