using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrengthDamage : Calculated
{
    public StrengthDamage (Pawn pawn) : base (pawn) {

    }

    protected override int CalculateBase () {
        return pawn.Strength.Influencer;
    }
}
