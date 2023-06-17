using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 10f;
    public float jumpForce = 5f;

    private bool isJumping = false;
    private bool isSprinting = false;
   // private bool isShooting = false;

    private Animator animator;
    private Rigidbody _rigidbody;

    private void Start()
    {
        animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Check for jump input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        // Check for sprint input
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }

        // Check for shoot input
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void FixedUpdate()
    {
        // Get horizontal and vertical input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(moveHorizontal, 0f, moveVertical).normalized;

        // Apply movement
        if (moveDirection.magnitude >= 0.1f)
        {
            Move(moveDirection);
        }
        else
        {
            StopMoving();
        }
    }

    private void Move(Vector3 direction)
    {
        // Calculate move speed based on sprinting
        float speed = isSprinting ? sprintSpeed : moveSpeed;

        // Apply movement animation
        animator.SetFloat("Speed", speed);

        // Rotate character towards movement direction
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);

        // Move character
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }

    private void StopMoving()
    {
        // Stop movement animation
        animator.SetFloat("Speed", 0f);
    }

    private void Jump()
    {
        if (!isJumping)
        {
            // Apply jump animation
            animator.SetTrigger("Jump");

            // Apply jump force to the rigidbody
            _rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            isJumping = true;
        }
    }

    private void Shoot()
    {
        // Apply shoot animation
        animator.SetTrigger("Shoot");

        // Perform shooting logic here
        // ...
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
