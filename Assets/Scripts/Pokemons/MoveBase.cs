
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string moveName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] PokemonType type;

    [SerializeField] int power;
    [SerializeField] int accurary;
    [SerializeField] int pp;
    [SerializeField] MoveCategory category;
    [SerializeField] MoveEffects effects;
    [SerializeField] MoveTarget target;


    public string MoveName
    {
        get { return moveName; }
    }

    public string Description
    {
        get { return description; }
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

    public MoveCategory Category
    {
        get { return category; }
    }

    public MoveEffects Effects
    {
        get { return effects; }
    }

    public MoveTarget Target
    {
        get { return target; }
    }

    //public bool IsSpelcial
    //{
    //    get
    //    {
    //        if (type == PokemonType.Normal || type == PokemonType.Fire || type == PokemonType.Water || type == PokemonType.Grass
    //            || type == PokemonType.Electric || type == PokemonType.Ice || type == PokemonType.Fighting || type == PokemonType.Poison
    //            || type == PokemonType.Ground || type == PokemonType.Flying || type == PokemonType.Psychic || type == PokemonType.Bug
    //            || type == PokemonType.Rock || type == PokemonType.Ghost || type == PokemonType.Dragon || type == PokemonType.Steel
    //            || type == PokemonType.Fairy)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //}
}

public enum Stat
{
    Attack,
    Defend,
    SpAttack,
    SpDefend,
    Speed
}

[System.Serializable]
public class MoveEffects
{
    [SerializeField] List<StatBoost> boosts;

    public List<StatBoost> Boosts 
    { 
        get { return boosts; } 
    }
}

[System.Serializable]
public class StatBoost
{
    public Stat stat;
    public int boost;
}

public enum MoveCategory
{
    Physical,
    Special,
    Status
}

public enum MoveTarget
{
    Foe,
    Self
}

