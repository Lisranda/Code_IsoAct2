using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Calculated
{
    public Armor (Pawn pawn) : base (pawn) {
    }

    protected override int CalculateBase () {
        return pawn.Dexterity.Influencer;
    }
}
