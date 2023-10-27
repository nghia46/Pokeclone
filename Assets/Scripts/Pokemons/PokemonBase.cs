using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string pokemonName;

    [TextArea]
    [SerializeField] string description;
    [SerializeField] Sprite frondSprites;
    [SerializeField] Sprite backSprites;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defend;
    [SerializeField] int spAttack;
    [SerializeField] int spDefend;
    [SerializeField] int speed;

    [SerializeField] List<LearnableMove> learnableMoves;

    public string PokemonName
    {
        get { return pokemonName; }
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite FrontSprite
    {
        get { return frondSprites; }
    }

    public Sprite BackSprite
    {
        get { return backSprites; }
    }

    public PokemonType Type1
    {
        get { return type1; }
    }

    public PokemonType Type2
    {
        get { return type2; }
    }

    public int MaxHp
    {
        get { return maxHp; }
    }

    public int Attack
    {
        get { return attack; }
    }

    public int Defend
    {
        get { return defend; }
    }

    public int SpAttack
    {
        get { return spAttack; }
    }

    public int SpDefend
    {
        get { return spDefend; }
    }

    public int Speed
    {
        get { return speed; }
    }

    public List<LearnableMove> LearnableMoves
    {
        get { return learnableMoves; }
    }
}

[System.Serializable]
public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase MoveBase
    {
        get { return moveBase; }
    }

    public int Level
    {
        get { return level; }
    }
}
public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Grass,
    Electric,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon,
    Dark,
    Steel,
    Fairy
}

public class TypeChart
{
    static float[][] chart =
    {
        //                 NOR   FIR   WAT   GRA   ELE   ICE   FIG   POI   GRO   FLY   PSY   BUG    ROC   GHO   DRA   DAR   STE   FAI
        /*NOR*/ new float[]{1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,  0.5f,   0f,   1f,   1f, 0.5f,   1f},
        /*FIR*/ new float[]{1f, 0.5f, 0.5f,   2f,   1f,   2f,   1f,   1f,   1f,   1f,   1f,   2f,  0.5f,   1f, 0.5f,   1f,   2f,   1f},
        /*WAT*/ new float[]{1f,   2f, 0.5f, 0.5f,   1f,   1f,   1f,   1f,   2f,   1f,   1f,   1f,   2f,    1f, 0.5f,   1f,   1f,   1f},
        /*GRA*/ new float[]{1f, 0.5f,   2f, 0.5f,   1f,   1f,   1f, 0.5f,   2f, 0.5f,   1f, 0.5f,   2f,    1f, 0.5f,   1f, 0.5f,   1f},
        /*ELE*/ new float[]{1f,   1f,   2f, 0.5f, 0.5f,   1f,   1f,   1f,   0f,   2f,   1f,   1f,   1f,    1f, 0.5f,   1f,   1f,   1f},
        /*ICE*/ new float[]{1f, 0.5f, 0.5f,   2f,   1f, 0.5f,   1f,   1f,   2f,   2f,   1f,   1f,   1f,    1f,   2f,   1f, 0.5f,   1f},
        /*FIG*/ new float[]{2f,   1f,   1f,   1f,   1f,   2f,   1f, 0.5f,   1f, 0.5f, 0.5f, 0.5f,   2f,    0f,   1f,   2f,   2f, 0.5f},
        /*POI*/ new float[]{1f,   1f,   1f,   2f,   1f,   1f,   1f, 0.5f, 0.5f,   1f,   1f,   1f, 0.5f,  0.5f,   1f,   1f,   0f,   2f},
        /*GRO*/ new float[]{1f,   2f,   1f, 0.5f,   2f,   1f,   1f,   2f,   1f,   0f,   1f, 0.5f,   2f,    1f,   1f,   1f,   2f,   1f},
        /*FLY*/ new float[]{1f,   1f,   1f,   2f, 0.5f,   1f,   2f,   1f,   1f,   1f,   1f,   2f, 0.5f,    1f,   1f,   1f, 0.5f,   1f},
        /*PSY*/ new float[]{1f,   1f,   1f,   1f,   1f,   1f,   2f,   2f,   1f,   1f, 0.5f,   1f,   1f,    1f,   1f, 0.5f, 0.5f,   1f},
        /*BUG*/ new float[]{1f, 0.5f,   1f,   2f,   1f, 0.5f, 0.5f,   1f,   1f, 0.5f,   2f,   1f,   1f,  0.5f,   1f,   2f, 0.5f, 0.5f},
        /*ROC*/ new float[]{1f,   2f,   1f,   1f,   1f,   2f, 0.5f,   1f, 0.5f,   2f,   1f,   2f,   1f,    1f,   1f,   1f, 0.5f,   1f},
        /*GHO*/ new float[]{0f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   2f,   1f,   1f,    2f,   1f, 0.5f,   1f,   1f},
        /*DRA*/ new float[]{1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,   1f,    1f,   2f, 0.5f,   1f,   0f},
        /*DAR*/ new float[]{1f,   1f,   1f,   1f,   1f,   1f, 0.5f,   1f,   1f,   1f,   2f,   1f,   1f,    2f,   1f, 0.5f,   1f, 0.5f},
        /*STE*/ new float[]{1f, 0.5f, 0.5f,   1f, 0.5f,   2f,   1f,   1f,   1f,   1f,   1f,   1f,   2f,    1f,   1f,   1f, 0.5f,   2f},
        /*FAI*/ new float[]{1f, 0.5f,   1f,   1f,   1f,   1f,   2f, 0.5f,   1f,   1f,   1f,   1f,   1f,    1f,   2f,   2f, 0.5f,   1f},

    };

    public static float GetEffectiveness(PokemonType attackType, PokemonType defendType)
    {
        if (attackType == PokemonType.None || defendType == PokemonType.None)
        {
            return 1;
        }

        int row = (int)attackType - 1;
        int col = (int)defendType - 1;

        return chart[row][col];
    }
}


