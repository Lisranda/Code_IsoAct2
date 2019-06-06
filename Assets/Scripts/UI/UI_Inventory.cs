using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    public GameObject slotPrefab;
    public GameObject invPanel;

    List<GameObject> invSlots = new List<GameObject> ();
    int numberOfSlots = 20;

    void Awake () {
    }

    void Start () {
        invPanel = Instantiate (invPanel , transform);
        SetBagDimensions ();
        GenerateSlots ();
        invPanel.SetActive (false);
    }

    void Update () {
        InputListener ();
    }

    void InputListener () {
        if (Input.GetKeyDown (KeyCode.I)) {
            ToggleInventoryPanel ();
        }
    }

    void ToggleInventoryPanel () {
        if (invPanel.activeInHierarchy)
            invPanel.SetActive (false);
        else
            invPanel.SetActive (true);
    }

    public void SetBagDimensions () {
        GridLayoutGroup grid = GetComponentInChildren<GridLayoutGroup> ();
        grid.cellSize = grid.cellSize;
        grid.spacing = grid.spacing;
        float slotHeight = grid.cellSize.y;
        float slotWidth = grid.cellSize.x;
        float slotSpacingY = grid.spacing.y;
        float slotSpacingX = grid.spacing.x;
        int paddingLeft = grid.padding.left;
        int paddingRight = grid.padding.right;
        int paddingTop = grid.padding.top;
        int paddingBottom = grid.padding.bottom;        
        int numberOfColumns = grid.constraintCount;
        int numberOfRows = Mathf.CeilToInt ((float)numberOfSlots / (float)numberOfColumns);
        float panelHeight = ((float)numberOfRows * slotHeight) + (((float)numberOfRows - 1) * slotSpacingY) + paddingTop + paddingBottom;
        float panelWidth = ((float)numberOfColumns * slotWidth) + (((float)numberOfColumns - 1) * slotSpacingX) + paddingLeft + paddingRight;
        Vector2 panelSize = new Vector2 (panelWidth , panelHeight);
        RectTransform invRect = invPanel.GetComponent<RectTransform> ();
        invRect.sizeDelta = panelSize;
    }

    public void GenerateSlots () {
        foreach (GameObject slot in invSlots) {
            Destroy (slot);
        }
        invSlots.Clear ();

        for (int i = 0 ; i < numberOfSlots ; i++) {
            GameObject slot = Instantiate (slotPrefab , invPanel.transform);
            slot.GetComponent<UI_Inventory_Slot> ().slotID = i;
            slot.name = (transform.root.name + " " + i);
            invSlots.Add (slot);
        }
    }
}
