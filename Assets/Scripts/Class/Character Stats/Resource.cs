using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Resource : Statistic
{
    public int CurrentValue { get; protected set; }

    protected virtual int BasePerLevel { get; }

    public Resource (Pawn pawn) : base (pawn) {
    }
}
