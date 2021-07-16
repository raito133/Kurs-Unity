using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] DeckOfCards deckOfCards;
    [SerializeField] Player player;
    [SerializeField] Player croupier;
    Player currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        deckOfCards.Shuffle();
        deckOfCards.PrintCards();
        currentPlayer = player;
        for (int i = 0; i < 2; i++)
        {
            DrawForCurrentPlayer(i);
        }
        currentPlayer = croupier;
        for (int i = 0; i < 2; i++)
        {
            DrawForCurrentPlayer(i);
        }
        currentPlayer.ReverseCard(0);
    }

    private void DrawForCurrentPlayer(int i)
    {
        Card card = deckOfCards.DrawNext();
        card.ReverseCard();
        card.gameObject.transform.position = new Vector3(
            currentPlayer.transform.position.x + i * 3,
            currentPlayer.transform.position.y, 0);
        currentPlayer.AddToHand(card);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
