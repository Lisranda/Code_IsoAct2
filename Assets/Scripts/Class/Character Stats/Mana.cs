using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mana : Resource 
{
    protected override int BasePerLevel { get; } = 10;

    public Mana (CharacterStats stats) : base (stats) {
        CurrentValue = MaxValue;
    }

    //protected override int CalculateBase () {
    //    return (pawn.Level * BasePerLevel) + (pawn.Wisdom.Influencer * 2);
    //}

}
