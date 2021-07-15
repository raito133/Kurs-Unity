using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    Player player;
    Enemy enemy;
    [SerializeField] TMP_Text prompt;
    [SerializeField] TMP_Text playerPokemonNameText;
    [SerializeField] TMP_Text enemyPokemonNameText;
    [SerializeField] GameObject promptText;
    [SerializeField] GameObject panelAbilities;
    [SerializeField] Slider enemyHp;
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

    public void OnFightButtonClick()
    {
        promptText.SetActive(false);
        panelAbilities.SetActive(true);
        int i = 0;
        foreach(TMP_Text text in panelAbilities.GetComponentsInChildren<TMP_Text>())
        {
            text.text = player.GetCurrentPokemon().GetAbilities()[i].Name;
            i++;
        }
        AddAbilities();
    }

    public void AddAbilities()
    {
        int i = 0;
        foreach (Button button in panelAbilities.GetComponentsInChildren<Button>())
        {
            Ability temp = player.GetCurrentPokemon().GetAbilities()[i];
            button.onClick.AddListener(delegate { UseAbility(temp); });
            i++;
        }
    }

    public void UseAbility(Ability ability)
    {
        enemy.GetCurrentPokemon().TakeDamage(ability.Damage);
        enemyHp.value = enemy.GetCurrentPokemon().GetHp();
    }



    public void Fight(Enemy enemy)
    {
        this.enemy = enemy;
    }


    
}
