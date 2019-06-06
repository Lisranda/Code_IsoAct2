using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatType {
    Strength,
    Dexterity,
    Constitution,
    Wisdom,
    Intelligence,
    HealthMax,
    HealthCurrent,
    ManaMax,
    ManaCurrent
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
            statList.Add (new Statistic (this));
        }
    }
}
