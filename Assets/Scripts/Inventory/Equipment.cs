using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : Item
{
    public List<StatMod> modifiers;

    //Statistic [] statArray = new Statistic [System.Enum.GetNames (typeof (StatType)).Length];

    public override void UseItem (Pawn userPawn) {
        foreach (StatMod mod in modifiers) {
            mod.Source = this;
            StatToAffect (userPawn , mod).AddModifier (mod);
        }
    }

    Statistic StatToAffect (Pawn userPawn, StatMod mod) {
        switch (mod.StatType) {
            case StatType.Strength: {
                    return userPawn.Strength;
                }
            case StatType.Dexterity: {
                    return userPawn.Dexterity;
                }
            case StatType.Constitution: {
                    return userPawn.Constitution;
                }
            case StatType.Wisdom: {
                    return userPawn.Wisdom;
                }
            case StatType.Intelligence: {
                    return userPawn.Intelligence;
                }
            case StatType.Health: {
                    return userPawn.Health;
                }
            case StatType.Mana: {
                    return userPawn.Mana;
                }
            case StatType.Armor: {
                    return userPawn.Armor;
                }
            case StatType.StrengthDamage: {
                    return userPawn.StrengthDamage;
                }
            case StatType.DexterityDamage: {
                    return userPawn.DexterityDamage;
                }
            case StatType.IntelligenceDamage: {
                    return userPawn.IntelligenceDamage;
                }
            default: {
                    return null;
                }
        }
        
    }
}
