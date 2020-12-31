using UnityEngine;

public class CameraController : MonoBehaviour {

    [Header("References")]
    [Tooltip("Reference to the main camera used for the player")]
    public AnimationManagerUI anim;

    private float moveSpeed = 0.5f;
    private float scrollSpeed = 10f;

    float horizontalInput;
    float verticalInput;
    float wheelInput;

    void Update () {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        wheelInput = Input.GetAxis("Mouse ScrollWheel");
    }

    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || verticalInput != 0) {
            transform.position += moveSpeed * new Vector3(horizontalInput, 0, verticalInput);
            anim.SetAnimation_Run();
        }

        if (Input.GetAxis("Mouse ScrollWheel") != 0) {
            transform.position += scrollSpeed * new Vector3(0, -Input.GetAxis("Mouse ScrollWheel"), 0);
        }
    }
}