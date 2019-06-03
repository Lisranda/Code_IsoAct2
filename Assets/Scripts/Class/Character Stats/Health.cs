using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : Resource 
{
    protected override int BasePerLevel { get; } = 10;

    public Health (CharacterStats stats) : base (stats) {
        CurrentValue = MaxValue;
    }

    //protected override int CalculateBase () {
    //    return (pawn.Level * BasePerLevel) + pawn.Constitution.Influencer;
    //}

    public void LowerHealth (uint amount) {
        if ((CurrentValue - amount) <= 0) {
            CurrentValue = 0;
            //TRIGGER DEATH EVENT
        } else {
            CurrentValue -= (int)amount;
        }
    }

    public void IncreaseHealth (uint amount) {
        if ((CurrentValue + amount) >= MaxValue) {
            CurrentValue = MaxValue;
        } else {
            CurrentValue += (int)amount;
        }
    }
}
