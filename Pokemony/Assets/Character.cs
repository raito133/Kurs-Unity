using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected Rigidbody2D rigidbody;
    [SerializeField] protected float speed = 5;
    protected List<Pokemon> pokemons = new List<Pokemon>();
    protected Pokemon currentPokemon;
    protected bool canMove = true;
    int currentIndex = 0;

    public Pokemon GetCurrentPokemon()
    {
        return currentPokemon;
    }

    public Pokemon GetNextPokemon()
    {
        if (currentIndex >= pokemons.Count)
            return null;
        return pokemons[currentIndex++];
    }
}
