using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Statistic
{
    [SerializeField] int baseValue;
    [SerializeField] int currentValue;

    public int GetValue () {
        return currentValue;
    }
}
