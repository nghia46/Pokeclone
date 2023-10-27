using System.Collections;
using UnityEngine;
using TMPro;
public class BattleHub : MonoBehaviour
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

    public IEnumerator UpdateHP()
    {
        yield return hpBar.SetHPSmooth((float)_pokemon.HP / _pokemon.MaxHp);
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
