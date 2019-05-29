using UnityEngine;

[RequireComponent(typeof(Pawn_Player))]
[RequireComponent(typeof(Motor))]
public class PlayerController : MonoBehaviour
{
    const float rayCameraDistance = 100f;

    public LayerMask terrainMask;
    Pawn_Player player;
    Motor motor;

    void Awake () {
        player = GetComponent<Pawn_Player> ();
        motor = GetComponent<Motor> ();
    }

    void Update () {
        LeftClickListener ();
    }
    
    void LeftClickListener () {
        if (Input.GetMouseButton (0)) {
            Ray ray = player.cam.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast (ray , out RaycastHit hit, rayCameraDistance, terrainMask)) {
                if (hit.transform.tag != "Terrain")
                    return;
                motor.MoveToTarget (hit.point);
            }
        }
    }
}
