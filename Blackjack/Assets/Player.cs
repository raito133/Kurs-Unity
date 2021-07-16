using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    List<Card> cards = new List<Card>();
    public void ReverseCard(int which)
    {
        cards[which].ReverseCard();
    }

    public void AddToHand(Card card)
    {
        cards.Add(card);
    }
}
