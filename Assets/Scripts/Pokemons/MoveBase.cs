
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string moveName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] MoveCategory category;
    [SerializeField] PokemonType type;

    [SerializeField] int power;
    [SerializeField] int accurary;
    [SerializeField] int pp;

    public string MoveName
    {
        get { return moveName; }
    }

    public string Description
    {
        get { return description; }
    }

    public MoveCategory Category
    {
        get { return category; }
    }

    public PokemonType Type
    {
        get { return type; }
    }

    public int Power
    {
        get { return power; }
    }

    public int Accurary
    {
        get { return accurary; }
    }

    public int PP
    {
        get { return pp; }
    }

    public bool IsSpelcial
    {
        get
        {
            if (type == PokemonType.Normal || type == PokemonType.Fire || type == PokemonType.Water || type == PokemonType.Grass
                || type == PokemonType.Electric || type == PokemonType.Ice || type == PokemonType.Fighting || type == PokemonType.Poison
                || type == PokemonType.Ground || type == PokemonType.Flying || type == PokemonType.Psychic || type == PokemonType.Bug
                || type == PokemonType.Rock || type == PokemonType.Ghost || type == PokemonType.Dragon || type == PokemonType.Steel
                || type == PokemonType.Fairy)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

public enum MoveCategory
{
    Physical,
    Special,
    Status
}
