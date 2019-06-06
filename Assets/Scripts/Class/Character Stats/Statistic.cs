using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Statistic
{
    protected List<StatMod> flatModifiers;
    protected List<StatMod> percentModifiers;

    protected bool isStale = true;
    protected int value;

    public CharacterStats stats;

    public int BaseValue { get; protected set; }

    public virtual int Value {
        get {
            if (isStale) {                
                value = CalculateValue ();
                isStale = false;
            }
            return value;
        }
    }

    public Statistic (CharacterStats stats) {
        this.stats = stats;
        flatModifiers = new List<StatMod> ();
        percentModifiers = new List<StatMod> ();
    }

    public virtual void ChangeBase (int newBase) {
        isStale = true;
        BaseValue = newBase;
    }

    public virtual List<StatMod> GetModifiers (ModifierType modType) {
        switch (modType) {
            case ModifierType.Flat:
                return flatModifiers;
            case ModifierType.Percent:
                return percentModifiers;
            default:
                return null;
        }
    }

    public virtual void AddModifier (StatMod modifier) {
        isStale = true;
        switch (modifier.ModType) {
            case ModifierType.Flat: {
                    flatModifiers.Add (modifier);
                    break;
                }
            case ModifierType.Percent: {
                    percentModifiers.Add (modifier);
                    break;
                }
        }
    }

    public virtual bool RemoveModifier (StatMod modifier) {
        switch (modifier.ModType) {
            case ModifierType.Flat: {
                    if (flatModifiers.Remove (modifier)) {
                        isStale = true;
                        return true;
                    }
                    return false;
                }
            case ModifierType.Percent: {
                    if (percentModifiers.Remove (modifier)) {
                        isStale = true;
                        return true;
                    }
                    return false;
                }
            default: {
                    return false;
                }
        }
    }

    public virtual bool RemoveAllModifiersFromSource (object source) {
        bool didRemove = false;

        for (int i = flatModifiers.Count - 1 ; i >= 0 ; i--) {
            if (flatModifiers [i].Source == source) {
                isStale = true;
                didRemove = true;
                flatModifiers.RemoveAt (i);
            }
        }

        for (int i = percentModifiers.Count - 1 ; i >= 0 ; i--) {
            if (percentModifiers [i].Source == source) {
                isStale = true;
                didRemove = true;
                percentModifiers.RemoveAt (i);
            }
        }
        return didRemove;
    }

    protected virtual int CalculateValue () {
        int calcValue = BaseValue;

        for (int i = 0 ; i < flatModifiers.Count ; i++) {
            calcValue += ((FlatMod)flatModifiers [i]).FlatValue;
        }

        for (int i = 0 ; i < percentModifiers.Count ; i++) {
            calcValue += Mathf.CeilToInt (BaseValue * ((PercentMod)percentModifiers [i]).PercentValue);
        }

        return calcValue;
    }
}
