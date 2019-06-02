using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ModifierType { Flat , Percent }
public enum ModifierDomain { Base , Standard }

[System.Serializable]
public class StatMod
{
    public StatType StatType;
    public string ModName;
    public ModifierType ModType;
    public ModifierDomain ModDomain;
    public int FlatValue;
    public float PercentValue;
    public object Source;

    public StatMod (string modName, int flatValue, object source = null) {
        this.ModName = modName;
        this.ModDomain = ModifierDomain.Standard;
        this.ModType = ModifierType.Flat;
        this.FlatValue = flatValue;
        this.Source = source;
    }

    public StatMod (string modName, float percentValue, object source = null) {
        this.ModName = modName;
        this.ModDomain = ModifierDomain.Standard;
        this.ModType = ModifierType.Percent;
        this.PercentValue = percentValue;
        this.Source = source;
    }
}
