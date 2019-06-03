using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<InventorySlot> slots = new List<InventorySlot> ();
    int invSize = 10;

    void Awake () {
        Initialize ();
    }

    void Initialize () {
        for (int i = 0 ; i < invSize ; i++) {
            slots.Add (new InventorySlot ());
        }
    }

    public bool Add (Item item) {
        foreach (InventorySlot s in slots) {
            if (s.IsEmpty) {
                s.Add (item);
                return true;
            }
        }
        return false;
    }

    public bool RemoveByItem (Item item) {
        foreach (InventorySlot s in slots) {
            if (s.Contains (item)) {
                s.Empty ();
                return true;
            }
        }
        return false;
    }

    public Item RemoveBySlot (InventorySlot s) {
        return s.Empty ();
    }

    public Item SwapByItem (Item oldItem, Item newItem) {
        foreach (InventorySlot s in slots) {
            if (s.Contains (oldItem)) {
                return s.Swap (newItem);
            }
        }
        return null;
    }

    public Item SwapBySlot (InventorySlot s, Item newItem) {
        return s.Swap (newItem);
    }
}
