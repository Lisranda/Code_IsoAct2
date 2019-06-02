using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntelligenceDamage : Calculated
{
    public IntelligenceDamage (Pawn pawn) : base (pawn) {

    }

    protected override int CalculateBase () {
        return pawn.Intelligence.Influencer;
    }
}
