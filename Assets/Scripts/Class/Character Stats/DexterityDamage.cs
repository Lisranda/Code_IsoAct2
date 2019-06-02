using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DexterityDamage : Calculated
{
    public DexterityDamage (Pawn pawn) : base (pawn) {

    }

    protected override int CalculateBase () {
        return pawn.Dexterity.Influencer;
    }
}
