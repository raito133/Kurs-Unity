using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        pokemons.Add(new Pokemon("Pikaczu", PokemonType.WATER, 80));
        currentPokemon = pokemons[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
