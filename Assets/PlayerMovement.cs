using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonPlayer : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    [Header("Mouse Look")]
    public float mouseSensitivity = 2f;
    public Transform playerCamera;

    private CharacterController controller;
    private float verticalLookRotation = 0f;
    private float verticalVelocity = 0f;
    private float gravity = -9.81f;

    private Vector2 moveInput;
    private Vector2 lookInput;
    private bool jumpPressed;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // These are called automatically by the PlayerInput component
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnLook(InputValue value)
    {
        lookInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        jumpPressed = value.isPressed;
    }

    void Update()
    {
        MouseLook();
        Move();
    }

    void MouseLook()
    {
        transform.Rotate(Vector3.up * lookInput.x * mouseSensitivity * Time.deltaTime * 100f);

        verticalLookRotation -= lookInput.y * mouseSensitivity * Time.deltaTime * 100f;
        verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);
        playerCamera.localEulerAngles = Vector3.right * verticalLookRotation;
    }

        void Move()
    {
        // Horizontal movement only
        Vector3 moveDirection = transform.right * moveInput.x + transform.forward * moveInput.y;
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        // Vertical movement (jump + gravity) handled separately
        if (controller.isGrounded)
        {
            verticalVelocity = -1f;

            if (jumpPressed)
            {
                verticalVelocity = jumpForce;
                jumpPressed = false;
            }
        }
        else
        {
            verticalVelocity += gravity * Time.deltaTime;
        }

        controller.Move(new Vector3(0, verticalVelocity, 0) * Time.deltaTime);
    }
}