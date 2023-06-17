using UnityEngine;

public class JumpScript : MonoBehaviour
{
    [SerializeField]private float jumpForce = 5f;

    private Rigidbody rb;
    private bool isGrounded = true;

    private void Start()
    {
      
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.J) && isGrounded)
        {
            Jump();
        }
    }

    private void Jump()
    {
        Rigidbody rb= GetComponent<Rigidbody>();    
        // Apply vertical force to make the character jump
        rb.velocity= new Vector3(jumpForce, 0f, 0f);
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 2);

        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the character has landed on the ground
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Ground");
            isGrounded = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Ground");
            isGrounded = true;
        }
    }
}
