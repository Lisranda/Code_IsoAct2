using UnityEngine;

public class MovementReticle : MonoBehaviour
{
    Motor motor;
    SpriteRenderer spriteRenderer;
    Quaternion rotation;

    void Awake () {
        motor = GetComponentInParent<Motor> ();
        spriteRenderer = GetComponentInChildren<SpriteRenderer> ();
        rotation = spriteRenderer.transform.rotation;
    }

    void Update () {
        
    }

    void LateUpdate () {
        UpdateReticle ();
    }

    void UpdateReticle () {
        if (motor.HasDestination ()) {
            spriteRenderer.gameObject.SetActive (true);
            spriteRenderer.transform.position = motor.EchoDestination ();
            spriteRenderer.transform.rotation = rotation;
        } else {
            spriteRenderer.gameObject.SetActive (false);
            spriteRenderer.transform.position = transform.position;
            spriteRenderer.transform.rotation = rotation;
        }
    }
}
