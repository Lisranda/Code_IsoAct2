using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FlatMod : StatMod
{
    public int FlatValue;

    public FlatMod (int flatValue , string modName , object source = null) : base (modName, source) {
        this.ModType = ModifierType.Flat;
        this.FlatValue = flatValue;
    }
}
