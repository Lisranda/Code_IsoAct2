using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : ScriptableObject
{
    public string itemName = "New Item";

    public virtual void UseItem (Pawn userPawn) {
    }
}
