using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] List<Item> inventory = new List<Item> ();
    int invSize = 10;

    void Awake () {
        Initialize ();
    }

    void Initialize () {
        //Get current size!!!
        for (int i = 0 ; i < invSize ; i++) {
            Debug.Log ("Adding slot");
            inventory.Add (null);
        }
    }

    public bool Add (Item item) {
        if (invSize == 0) {
            return false;
        }

        for (int i = 0 ; i < invSize ; i++) {
            if (inventory [i] != null) {
                if (i == invSize - 1) {
                    return false;
                }
                continue;
            }
            inventory [i] = item;
            break;
        }
        //Issue Callback?
        return true;
    }
}
