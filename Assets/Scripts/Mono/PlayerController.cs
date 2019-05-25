using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Pawn_Player))]
[RequireComponent(typeof(Motor))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] LayerMask terrainMask;
    Pawn_Player player;
    Motor motor;

    void Awake () {
        player = GetComponent<Pawn_Player> ();
        motor = GetComponent<Motor> ();
    }

    void Update () {        
        if (Input.GetMouseButton (0)) {
            Ray ray = player.cam.ScreenPointToRay (Input.mousePosition);
            if (Physics.Raycast (ray, out RaycastHit hit)) {
                if (hit.transform.tag != "Terrain")
                    return;
                motor.MoveToTarget (hit.point);
            }
        }
    }    
}
