using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementReticle : MonoBehaviour
{
    Motor motor;
    SpriteRenderer spriteRenderer;

    void Awake () {
        motor = GetComponentInParent<Motor> ();
        spriteRenderer = GetComponentInChildren<SpriteRenderer> ();
    }

    void LateUpdate () {
        if (motor.HasDestination ()) {
            spriteRenderer.gameObject.SetActive (true);
            spriteRenderer.transform.position = motor.EchoDestination ();
        } else {
            spriteRenderer.gameObject.SetActive (false);
            spriteRenderer.transform.position = transform.position;
        }
    }
}
