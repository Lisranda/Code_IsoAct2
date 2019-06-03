using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Attribute : Statistic
{
    const int initialAttributeValue = 5;    

    public int Influencer {
        get {
            return Mathf.FloorToInt (MaxValue * 0.5f);
        }
    }

    public Attribute (CharacterStats stats) : base (stats) {
        
    }
    
    protected override int CalculateBase () {
        return initialAttributeValue;
    }
}
