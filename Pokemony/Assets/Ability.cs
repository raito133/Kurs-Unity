using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    public string Name { get; }
    public int Damage { get; }
    public int Cost { get; }
    public Ability(string name, int damage, int cost)
    {
        this.Name = name;
        this.Damage = damage;
        this.Cost = cost;
    }
}
