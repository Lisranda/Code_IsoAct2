using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ModifierType { Flat , Percent }
public enum ModifierDomain { Standard , Base }

[System.Serializable]
public abstract class StatMod
{
    public ModifierDomain ModDomain;
    public StatType StatType;
    public string ModName;
    public object Source;

    public ModifierType ModType { get; protected set; }

    public StatMod (string modName , object source = null) {
        this.ModDomain = ModifierDomain.Standard;
        this.ModName = modName;
        this.Source = source;
    }
}
