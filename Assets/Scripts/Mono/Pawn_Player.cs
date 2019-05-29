using UnityEngine;

public class Pawn_Player : Pawn
{
    public Camera cam;

    void Awake () {
        cam = GetComponentInChildren<Camera> ();
    }
}
