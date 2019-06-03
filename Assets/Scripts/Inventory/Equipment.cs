using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : Item
{
    public List<FlatMod> flatModifiers;
    public List<PercentMod> percentModifiers;

    public override void UseItem (CharacterStats stats) {
        foreach (StatMod mod in flatModifiers) {
            mod.Source = this;
            stats.AddStatModifier (mod);
        }
        foreach (StatMod mod in percentModifiers) {
            mod.Source = this;
            stats.AddStatModifier (mod);
        }
    }
}
