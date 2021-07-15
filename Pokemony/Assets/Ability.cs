using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    string name;
    int damage;
    int cost;
    public Ability(string name, int damage, int cost)
    {
        this.name = name;
        this.damage = damage;
        this.cost = cost;
    }
}
