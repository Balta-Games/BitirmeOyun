using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController Controller;
    public float Speed;
    public Transform Cam;
    private float Gravity;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        Gravity -= 9.81f * Time.deltaTime;
        
        Vector3 Movement = Cam.transform.right * Horizontal + Cam.transform.forward * Vertical;
        Movement.y = Gravity;

        Controller.Move(Movement);

        if (Controller.isGrounded)
        {
            Gravity = 0f;
        }

        if (Movement.magnitude != 0f)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Cam.GetComponent<CameraMove>().sensivity * Time.deltaTime);


            Quaternion CamRotation = Cam.rotation;
            CamRotation.x = 0f;
            CamRotation.z = 0f;

            transform.rotation = Quaternion.Lerp(transform.rotation, CamRotation, 0.1f);
        }

        if (animator != null)
        {
            Vector3 horizontalVel = Controller.velocity;
            horizontalVel.y = 0f;
            animator.SetBool("isRunning", horizontalVel.magnitude > 0.1f);
        }       
    }
}
