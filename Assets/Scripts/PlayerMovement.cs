using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 input;
    private CharacterController characterController;
    private Vector3 direction;
    private float speed = 5f;
    private float gravity = -9.81f;
    private float velocity;
    private Camera mainCamera;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        mainCamera = Camera.main;
    }

    private void Update()
    {
        ApplyRotation();
        ApplyGravity();
        ApplyMovement();
        ResetVelocity();
        Debug.Log(velocity);
    }
    private void ApplyMovement()
    {
        characterController.Move(direction * speed * Time.deltaTime);
    }

    private void ApplyRotation()
    {
        if (input.sqrMagnitude == 0f) return;

        direction = Quaternion.Euler(0, mainCamera.transform.eulerAngles.y, 0) * new Vector3(input.x, 0, input.y);

        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 500f);
    }

        public void Jump(InputAction.CallbackContext context)
    {
        if(!context.started) return;
        if(!characterController.isGrounded) return;

        velocity += 5f;
        
    }

    private void ApplyGravity()
    {
        if(!characterController.isGrounded)
        {
            velocity += gravity * Time.deltaTime;
        }
        
        direction.y = velocity;
    }

    private void ResetVelocity()
    {
        if(characterController.isGrounded)
        {
            velocity = -1f;
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
        direction = new Vector3(input.x, 0, input.y);
    }

}