using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController Controller;
    public float Speed;
    private float RotationSpeed = 10f;
    private float JumpStrength = 4.5f;
    public Transform Cam;
    private float Gravity;
    private Animator animator;
    private float HangingTime;
    private float HangingLimit = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    public bool IsGrounded()
    {
        return HangingTime < HangingLimit;
    }

    public void HangingControl()
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
            Gravity = JumpStrength; 
        }
        
        Gravity -= 9.81f * Time.deltaTime; // Applying Gravity
        
        // Calculating Movement
        Vector3 Movement = Cam.transform.right * Horizontal + Cam.transform.forward * Vertical;
        Movement.y = Gravity * Time.deltaTime;
        Controller.Move(Movement);

        if (IsGrounded() && Gravity < 0f) // Reset gravity when on ground
        {
            Gravity = -1f;
        }

        // Handling Character's Rotation
        Vector3 moveDir = new Vector3(Movement.x, 0f, Movement.z);
        if (moveDir.sqrMagnitude > 0.0001f)
        {
            Quaternion targetRot = Quaternion.LookRotation(moveDir.normalized);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, RotationSpeed * Time.deltaTime);
        }

        // Aligning Player Rotation with Camera when Moving
        if (Movement.magnitude != 0f)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Cam.GetComponent<CameraMove>().sensivity * Time.deltaTime);

            Quaternion CamRotation = Cam.rotation;
            CamRotation.x = 0f;
            CamRotation.z = 0f;

            transform.rotation = Quaternion.Lerp(transform.rotation, CamRotation, 0.1f);
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
