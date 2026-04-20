using UnityEngine;

public class CatJump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] public Rigidbody rigidBody;
    [SerializeField] public SpriteRenderer spriteRenderer;
    [SerializeField] private float jumpForce = 6;
    private float playerHalfHeight;

    private void Start()
    {
        playerHalfHeight = spriteRenderer.bounds.extents.y;
    }

    
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && GetIsGrounded())
        {
            rigidBody.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

    private bool GetIsGrounded()
    {
        return Physics.Raycast(transform.position, Vector2.down, playerHalfHeight + 0.1f, LayerMask.GetMask("Ground"));
    }

    private void Jump()
    {
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode.Impulse);
    }
}
