using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    [SerializeField] private float xMoveSpeed;
    [SerializeField] private float zMoveSpeed;
    [SerializeField] private float xRotateSpeed;
    [SerializeField] private float yRotateSpeed;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Transform cameraTransform;
    
    private CharacterController _characterController;

    private void Awake() {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update() {
        // Movement
        float xMove = xMoveSpeed * (Input.GetAxis("Horizontal") * Time.deltaTime);
        float zMove = zMoveSpeed * (Input.GetAxis("Vertical") * Time.deltaTime);
        Vector3 movement = new Vector3(xMove, 0, zMove);
        movement = playerTransform.TransformDirection(movement);
        _characterController.Move(movement);
        // Rotation
        float xRotate = xRotateSpeed * (Input.GetAxis("Mouse Y") * Time.deltaTime);
        float yRotate = yRotateSpeed * (Input.GetAxis("Mouse X") * Time.deltaTime);
        playerTransform.Rotate(0, yRotate, 0);
        cameraTransform.Rotate(xRotate, 0, 0);
    } 
    
}