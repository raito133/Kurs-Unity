using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PokemonType
{
    FIRE = 0,
    WATER,
    GROUND,
    FLYING
}

public class Pokemon
{
    public string SpeciesName { get; }
    int hp;
    PokemonType type;
    List<Ability> abilities = new List<Ability>();
    public Pokemon(string speciesName, PokemonType type, int hp)
    {
        this.SpeciesName = speciesName;
        this.type = type;
        this.hp = hp;
        this.abilities.Add(new Ability("Push", 20, 0));
        this.abilities.Add(new Ability("Pull", 20, 0));
        this.abilities.Add(new Ability("Zap", 20, 0));
        this.abilities.Add(new Ability("Desttt", 20, 0));
    }

    public List<Ability> GetAbilities()
    {
        return abilities;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
    }

    public int GetHp()
    {
        return hp;
    }
}
