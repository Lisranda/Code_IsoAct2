using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attribute : Statistic
{
    const int initialAttributeValue = 5;    

    public int Influencer {
        get {
            return Mathf.FloorToInt (MaxValue * 0.5f);
        }
    }

    public Attribute (Pawn pawn) : base (pawn) {
        
    }
    
    protected override int CalculateBase () {
        return initialAttributeValue;
    }
}
