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

    public Pokemon GetCurrentPokemon()
    {
        return currentPokemon;
    }
}
