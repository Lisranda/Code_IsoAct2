using UnityEngine;

public class Pawn_Player : Pawn
{
    public Camera cam;

    protected override void Awake () {
        base.Awake ();
        cam = GetComponentInChildren<Camera> ();
    }
}
