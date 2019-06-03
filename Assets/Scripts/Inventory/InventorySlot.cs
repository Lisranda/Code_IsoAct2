using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlot
{
    [SerializeField] Item cont = null;

    public bool IsEmpty {
        get {
            return (cont == null);
        }
    }

    public bool Contains (Item item) {
        return (cont == item);
    }

    public bool Add (Item item) {
        if (!IsEmpty)
            return false;
        cont = item;
        return true;
    }

    public Item Empty () {
        if (IsEmpty)
            return null;
        Item i = cont;
        cont = null;
        return i;
    }

    public Item Swap (Item item) {
        if (IsEmpty) {
            cont = item;
            return null;
        }
        Item i = cont;
        cont = item;
        return i;
    }
}
