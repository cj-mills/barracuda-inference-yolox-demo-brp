using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 200.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3();

        // Horizontal movement (A/D or LeftArrow/RightArrow)
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            movement.x -= moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            movement.x += moveSpeed * Time.deltaTime;

        // Forward/Backward movement (W/S or UpArrow/DownArrow)
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            movement.z += moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            movement.z -= moveSpeed * Time.deltaTime;

        // Vertical movement (Q/E for down and up)
        if (Input.GetKey(KeyCode.Q))
            movement.y -= moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            movement.y += moveSpeed * Time.deltaTime;

        // Use TransformDirection to get a direction relative to the camera's orientation.
        movement = transform.TransformDirection(movement);

        transform.Translate(movement, Space.World);

        // Rotate camera using the mouse while holding the right mouse button.
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up * mouseX, Space.World);
            transform.Rotate(Vector3.left * mouseY, Space.Self);
        }
    }
}
