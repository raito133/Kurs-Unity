using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    string color;
    string number;
    SpriteRenderer spriteRenderer;
    Sprite sprite;
    public void GenerateCard(string color, string number)
    {
        this.color = color;
        this.number = number;
        sprite = Resources.Load<Sprite>($"Images/Cards/card-{this.color}-{this.number}");
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite;

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
