using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckOfCards : MonoBehaviour
{
    int i = 0;
    List<Card> cards = new List<Card>();
    string[] colors = new string[] { "clubs", "diamonds", "spades", "hearts" };
    string[] figures = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "1", "11", "12", "13" };
    [SerializeField] GameObject cardPrefab;
    public void Awake()
    {
        GenerateCards();
    }

    // zbêdna metoda 
    //public DeckOfCards(string[] colors)
    //{
    //    this.colors = colors;
    //    GenerateCards();
    //}

    private void GenerateCards()
    {
        foreach (string color in colors)
        {
            foreach (string figure in figures)
            {
                GameObject cardObject = Instantiate(cardPrefab, this.transform.position, Quaternion.identity);
                cardObject.AddComponent<Card>();
                cardObject.GetComponent<Card>().SetupCard(color, figure);
                cards.Add(cardObject.GetComponent<Card>());
            }
        }
    }

    public void PrintCards()
    {
        foreach (Card card in cards)
        {
            Debug.Log(card.ToString());
        }
    }

    public void Shuffle()
    {
        int n = cards.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            Card value = cards[k];
            cards[k] = cards[n];
            cards[n] = value;
        }
    }

    public Card DrawNext()
    {
        if (i == cards.Count)
            return null;
        else
        {
            return cards[i++];
        }
    }
}
