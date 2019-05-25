using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    GameObject player;
    Quaternion initRotation;

    void Awake () {
        player = transform.parent.gameObject;
        initRotation = transform.rotation;
        transform.position = player.transform.position - 15 * transform.forward;
    }

    void LateUpdate () {
        transform.rotation = initRotation;
        transform.position = player.transform.position - 15 * transform.forward;
    }
}
