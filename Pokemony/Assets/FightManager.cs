using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FightManager : MonoBehaviour
{
    Player player;
    Pokemon currentFightingPokemon;
    Enemy enemy;
    [SerializeField] TMP_Text prompt;
    [SerializeField] TMP_Text playerPokemonNameText;
    [SerializeField] TMP_Text enemyPokemonNameText;
    [SerializeField] GameObject promptText;
    [SerializeField] GameObject panelAbilities;
    [SerializeField] Slider enemyHp;
    [SerializeField] Slider playerHp;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        currentFightingPokemon = player.GetCurrentPokemon();
        prompt.text = $"What will {currentFightingPokemon.SpeciesName} do?";
        playerPokemonNameText.text = currentFightingPokemon.SpeciesName;
        enemyPokemonNameText.text = enemy.GetCurrentPokemon().SpeciesName;
    }

    private void ResetState()
    {
        playerHp.value = currentFightingPokemon.GetHp();
        prompt.text = $"What will {currentFightingPokemon.SpeciesName} do?";
        playerPokemonNameText.text = currentFightingPokemon.SpeciesName;
        int i = 0;
        foreach (TMP_Text text in panelAbilities.GetComponentsInChildren<TMP_Text>())
        {
            text.text = currentFightingPokemon.GetAbilities()[i].Name;
            i++;
        }
        i = 0;
        foreach (Button button in panelAbilities.GetComponentsInChildren<Button>())
        {
            button.onClick.RemoveAllListeners();
            Ability temp = currentFightingPokemon.GetAbilities()[i];
            button.onClick.AddListener(delegate { UseAbility(temp); });
            i++;
        }
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
            text.text = currentFightingPokemon.GetAbilities()[i].Name;
            i++;
        }
        AddAbilities();
    }

    public void AddAbilities()
    {
        int i = 0;
        foreach (Button button in panelAbilities.GetComponentsInChildren<Button>())
        {
            Ability temp = currentFightingPokemon.GetAbilities()[i];
            button.onClick.AddListener(delegate { UseAbility(temp); });
            i++;
        }
    }

    public void UseAbility(Ability ability)
    {
        enemy.GetCurrentPokemon().TakeDamage(ability.Damage);
        enemyHp.value = enemy.GetCurrentPokemon().GetHp();
        FightBack();
    }

    public void FightBack()
    {
        if(enemy.GetCurrentPokemon().GetHp() <= 0)
        {
            Destroy(enemy.gameObject);
            HandleEnd();
        }
        Ability ability = enemy.GetCurrentPokemon().GetAbilities()[Random.Range(0, 4)];
        currentFightingPokemon.TakeDamage(ability.Damage);
        playerHp.value = currentFightingPokemon.GetHp();
        if (currentFightingPokemon.GetHp() <= 0)
        {
            currentFightingPokemon = player.GetNextPokemon();
            if(currentFightingPokemon == null)
            {
                HandleEnd();
            }
            else
            {
                ResetState();
            }
            
        }

    }
    private void HandleEnd()
    {
        this.gameObject.SetActive(false);
    }


    public void Fight(Enemy enemy)
    {
        this.enemy = enemy;
    }


    
}
