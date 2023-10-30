using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PartyMemberUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameTxt;
    [SerializeField] TextMeshProUGUI lvTxt;
    [SerializeField] HpBar hpBar;
    // Start is called before the first frame update

    Pokemon _pokemon;

    public void setData(Pokemon pokemon)
    {
        _pokemon = pokemon;
        nameTxt.text = pokemon.Base.PokemonName;
        lvTxt.text = "lvl " + pokemon.Level;
        hpBar.SetHP((float)pokemon.HP / pokemon.MaxHp);

    }
}
