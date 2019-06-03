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

[System.Serializable]
public class CharacterStats : MonoBehaviour
{
    public List<Statistic> statList = new List<Statistic> ();

    void Awake () {
        GenerateStats ();
    }

    void Start () {
    }

    public void AddStatModifier (StatMod modifier) {
        statList [(int)modifier.StatType].AddModifier (modifier);
    }

    void GenerateStats () {
        foreach (string s in System.Enum.GetNames (typeof (StatType))) {
            switch (s) {
                case "Strength": {
                        Statistic stat = new Attribute (this);
                        statList.Add (stat);
                        break;
                    }
                case "Dexterity": {
                        Statistic stat = new Attribute (this);
                        statList.Add (stat);
                        break;
                    }
                case "Constitution": {
                        Statistic stat = new Attribute (this);
                        statList.Add (stat);
                        break;
                    }
                case "Wisdom": {
                        Statistic stat = new Attribute (this);
                        statList.Add (stat);
                        break;
                    }
                case "Intelligence": {
                        Statistic stat = new Attribute (this);
                        statList.Add (stat);
                        break;
                    }
                case "Health": {
                        Statistic stat = new Health (this);
                        statList.Add (stat);
                        break;
                    }
                case "Mana": {
                        Statistic stat = new Mana (this);
                        statList.Add (stat);
                        break;
                    }
                case "Armor": {
                        Statistic stat = new Armor (this);
                        statList.Add (stat);
                        break;
                    }
                case "StrengthDamage": {
                        Statistic stat = new StrengthDamage (this);
                        statList.Add (stat);
                        break;
                    }
                case "DexterityDamage": {
                        Statistic stat = new DexterityDamage (this);
                        statList.Add (stat);
                        break;
                    }
                case "IntelligenceDamage": {
                        Statistic stat = new IntelligenceDamage (this);
                        statList.Add (stat);
                        break;
                    }
                default: {
                        Debug.LogError ("Tried to make a stat that the Generator doesn't have a case for: " + s);
                        break;
                    }
            }
        }
    }
}
