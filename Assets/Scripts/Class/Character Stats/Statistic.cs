using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatType {
    Strength,
    Dexterity,
    Constitution,
    Wisdom,
    Intelligence,
    Health,
    Mana,
    Armor,
    StrengthDamage,
    DexterityDamage,
    IntelligenceDamage
}

public abstract class Statistic
{
    protected List<StatMod> flatModifiers;
    protected List<StatMod> percentModifiers;

    protected bool isDirty = true;
    protected int value;

    protected bool isBaseStale = true;
    protected int swapBase;
    protected int staleBase = int.MinValue;

    public Pawn pawn;

    public virtual int BaseValue {
        get {
            if (isBaseStale) {
                swapBase = CalculateBase ();
                isBaseStale = false;
            }
            return swapBase;
        }
    }

    public virtual int MaxValue {
        get {
            if (isDirty || staleBase != BaseValue) {
                staleBase = BaseValue;
                value = CalculateMaxValue ();
                isDirty = false;
            }
            return value;
        }
    }

    public Statistic (Pawn pawn) {
        this.pawn = pawn;
        flatModifiers = new List<StatMod> ();
        percentModifiers = new List<StatMod> ();
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
        isDirty = true;
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
                        isDirty = true;
                        return true;
                    }
                    return false;
                }
            case ModifierType.Percent: {
                    if (percentModifiers.Remove (modifier)) {
                        isDirty = true;
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
                isDirty = true;
                didRemove = true;
                flatModifiers.RemoveAt (i);
            }
        }

        for (int i = percentModifiers.Count - 1 ; i >= 0 ; i--) {
            if (percentModifiers [i].Source == source) {
                isDirty = true;
                didRemove = true;
                percentModifiers.RemoveAt (i);
            }
        }
        return didRemove;
    }

    protected virtual int CalculateMaxValue () {
        int calcValue = BaseValue;

        for (int i = 0 ; i < flatModifiers.Count ; i++) {
            calcValue += flatModifiers [i].FlatValue;
        }

        for (int i = 0 ; i < percentModifiers.Count ; i++) {
            calcValue += Mathf.CeilToInt (BaseValue * percentModifiers [i].PercentValue);
        }

        return calcValue;
    }

    protected virtual int CalculateBase () {
        return 0;
    }
}
