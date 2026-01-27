using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController Controller;
    private Animator animator;
    public Transform Cam;

    private float Speed = 4f;
    private float RotationSpeed = 20f;
    private float JumpStrength = 4.5f;
    private float Gravity = -9.81f;
    private Vector3 Velocity;
    private float HangingTime;
    private float HangingLimit = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Check if the player is grounded
    private bool IsGrounded() 
    {
        return HangingTime < HangingLimit;
    }

    // Manage hanging time when not grounded
    private void HangingControl()
    {
        if (Controller.isGrounded)
        {
            HangingTime = 0;
        }
        else
        {
            HangingTime += Time.deltaTime;
        }
    }

    // Update is called once per frame
    void Update()
    {
        HangingControl();

        // Getting Input
        float Horizontal = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            Velocity.y = JumpStrength; 
        }
        
        // Calculating Movement
        Vector3 Movement = Cam.transform.right * Horizontal + Cam.transform.forward * Vertical;

        // Applying Gravity
        Velocity.y += Gravity * Time.deltaTime; 
        Movement.y = Velocity.y * Time.deltaTime; 
        if (IsGrounded() && Velocity.y <= 0f) // Reset gravity when on ground
        {
            Velocity.y = -1f;// Small negative value to keep the player grounded
        }

        Controller.Move(Movement);

        // Handling Character's Rotation
        Vector3 moveDir = new Vector3(Movement.x, 0f, Movement.z);
        if (moveDir.sqrMagnitude > 0.0001f)
        {
            Quaternion targetRot = Quaternion.LookRotation(moveDir.normalized);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, RotationSpeed * Time.deltaTime);
        }
        
        // Updating Animator Parameters
        if (animator != null)
        {
            Vector3 horizontalVel = Controller.velocity;
            horizontalVel.y = 0f;
            animator.SetBool("isRunning", (horizontalVel.magnitude > 0.1f) && IsGrounded());
            animator.SetBool("isJumping", !IsGrounded());
        }       
    }
}
