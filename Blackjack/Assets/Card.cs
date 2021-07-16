using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    string color;
    string number;
    SpriteRenderer spriteRenderer;
    Sprite cardSprite;
    Sprite reversedSprite;
    bool isHidden = true;
    /// <summary>
    /// Ustawianie koloru i numeru karty
    /// oraz odpowiadaj¹cego obrazka
    /// </summary>
    /// <param name="color">Kolor karty</param>
    /// <param name="number">Numer karty</param>
    public void SetupCard(string color, string number)
    {
        this.color = color;
        this.number = number;
        cardSprite = Resources.Load<Sprite>($"Images/Cards/card-{this.color}-{this.number}");
        reversedSprite = Resources.Load<Sprite>($"Images/Cards/card-back1");
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = reversedSprite;
    }

    // zwrócenie stringa karty jako jego koloru i liczby
    public override string ToString()
    {
        return color + " " + number;
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReverseCard()
    {
        if(isHidden)
        {
            spriteRenderer.sprite = cardSprite;
        }
        else
        {
            spriteRenderer.sprite = reversedSprite;
        }
        isHidden = !isHidden;
    }
}
