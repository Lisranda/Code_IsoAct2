using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    GameObject player;
    Quaternion initRotation;
    Camera cam;

    void Awake () {
        player = transform.parent.gameObject;
        initRotation = transform.rotation;
        transform.position = player.transform.position - 50 * transform.forward;
        cam = GetComponent<Camera> ();
    }

    void Update () {
        CameraZoom ();
        FixCamera ();
    }

    void FixCamera () {
        transform.rotation = initRotation;
        transform.position = player.transform.position - 50 * transform.forward;
    }

    void CameraZoom () {
        if (Input.GetAxis ("Mouse ScrollWheel") > 0 && cam.orthographicSize > 2)
            cam.orthographicSize--;
        if (Input.GetAxis ("Mouse ScrollWheel") < 0 && cam.orthographicSize < 10)
            cam.orthographicSize++;
    }
}
