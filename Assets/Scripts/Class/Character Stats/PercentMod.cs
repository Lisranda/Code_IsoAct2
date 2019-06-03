using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PercentMod : StatMod
{
    public float PercentValue;

    public PercentMod (float percentValue , string modName , object source = null) : base (modName , source) {
        this.ModType = ModifierType.Percent;
        this.PercentValue = percentValue;
    }
}
