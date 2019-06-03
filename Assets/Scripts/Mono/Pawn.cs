using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{
    public GameObject ItemTestPrefab;
    public Inventory Inventory;

    protected virtual void Awake () {

    }

    protected virtual void Start () {

    }

    protected virtual void Update () {
        if (Input.GetKeyDown (KeyCode.Space)) {
            Inventory.Add (ItemTestPrefab.GetComponent<Interact> ().Item);
        }
        if (Input.GetKeyDown (KeyCode.Return)) {
        }
    }
}
