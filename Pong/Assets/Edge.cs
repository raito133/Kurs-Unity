using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{
    [SerializeField]
    bool isPlayerOneEdge;
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject
            .FindGameObjectWithTag("GameManager")
            .GetComponent<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            gameManager.IncreaseScore(isPlayerOneEdge);
        }
    }
}
