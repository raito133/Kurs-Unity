using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    Player player;
    Enemy enemy;
    [SerializeField] TMP_Text prompt;
    [SerializeField] TMP_Text playerPokemonNameText;
    [SerializeField] TMP_Text enemyPokemonNameText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        prompt.text = $"What will {player.GetCurrentPokemon().SpeciesName} do?";
        playerPokemonNameText.text = player.GetCurrentPokemon().SpeciesName;
        enemyPokemonNameText.text = enemy.GetCurrentPokemon().SpeciesName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRunButtonClick()
    {
        this.gameObject.SetActive(false);
    }

    public void Fight(Enemy enemy)
    {
        this.enemy = enemy;
    }

    
}
