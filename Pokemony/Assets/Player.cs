using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        pokemons.Add(new Pokemon("Charmander", PokemonType.FIRE, 100));
        currentPokemon = pokemons[0];
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*speed, 
            Input.GetAxisRaw("Vertical")*speed);
        if (Input.GetAxisRaw("Horizontal") == -1)
            GetComponent<SpriteRenderer>().flipX = true;
        else
            GetComponent<SpriteRenderer>().flipX = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>()
                .Fight(collision.gameObject.GetComponent<Enemy>());
        }
    }
}
