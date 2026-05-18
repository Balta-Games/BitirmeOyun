using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 input;
    private CharacterController characterController;
    private Vector3 direction;
    private float gravity = -9.81f;
    private float velocity;
    private float jumpHeight;
    private int maxJumpNumber;
    private int remainingJumpNumber;
    private Camera mainCamera;
    [SerializeField] private Movement movement;
    private Animator animator;
    private bool isAttacking;
    private bool isBlocking;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        mainCamera = Camera.main;
        movement = new Movement(2f, 10f);
    }

    private void Update()
    {
        ApplyRotation();
        ApplyGravity();
        ApplyMovement();
        ResetVelocity();
        UpdateAnimation();
    }
    private void ApplyMovement()
    {
        if(isAttacking ||isBlocking)
        {
            movement.currentSpeed = 0f;
            return;
        }

        float targetSpeed = movement.isSprinting ? movement.speed * movement.multiplier : movement.speed;
        movement.currentSpeed = Mathf.MoveTowards(movement.currentSpeed, targetSpeed, movement.acceleration * Time.deltaTime);
        characterController.Move(direction * movement.currentSpeed * Time.deltaTime);
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
        if(!characterController.isGrounded && remainingJumpNumber <= 0) return;
        else if(characterController.isGrounded) remainingJumpNumber = maxJumpNumber;
        
        velocity += jumpHeight;
        remainingJumpNumber--;
        animator.SetTrigger("Jumped");
        PlayerAnalytics.Instance.AddJump();
    }

    private void ApplyGravity()
    {
        if(!characterController.isGrounded)
        {
            velocity += gravity * Time.deltaTime;
        }
        
        direction.y = velocity;
    }

    private void UpdateAnimation()
    {
        bool hasMovementInput = new Vector3(direction.x, 0, direction.z).sqrMagnitude > 0.01f;
        bool isMoving = hasMovementInput && !movement.isSprinting;
        bool isSprinting = hasMovementInput && movement.isSprinting;
        bool isFalling = direction.y <= 0f;

        animator.SetBool("isMoving", isMoving);
        animator.SetBool("isSprinting", isSprinting);
        animator.SetBool("isGrounded", characterController.isGrounded);
        animator.SetBool("isFalling", isFalling);
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

    public void Attack(InputAction.CallbackContext context)
    {
        if(isAttacking) return;
        isAttacking = true;
        animator.SetTrigger("isAttacked");
        PlayerAnalytics.Instance.AddAttack();
    }
    public void EndAttack()
    {
        isAttacking = false;
    }
    public void Block(InputAction.CallbackContext context)
    {
        isBlocking = context.ReadValueAsButton();

        animator.SetBool("isBlocking", isBlocking);
        animator.SetTrigger("rightClicked");

        if(context.started)
        {
            PlayerAnalytics.Instance.AddBlock();
        }
    }

    public void Sprint(InputAction.CallbackContext context)
    {
        movement.isSprinting = context.started || context.performed;

        if(context.started)
        {
            PlayerAnalytics.Instance.AddSprint();
        }
    }

    public void SetSpeed(float newSpeed)
    {
        movement.speed = newSpeed;
    }

    public void SetJumpHeight(float newJumpHeight)
    {
        jumpHeight = newJumpHeight;
    }

    public void SetJumpNumber(int newJumpNumber)
    {
        maxJumpNumber = newJumpNumber;
        remainingJumpNumber = newJumpNumber;
    }
}

[Serializable]
internal struct Movement
{
    internal float speed;
    internal float multiplier;
    internal float acceleration;
    internal bool isSprinting;
    internal float currentSpeed;
    internal Movement(float multiplier, float acceleration)
    {
        speed = 0f;
        this.multiplier = multiplier;
        this.acceleration = acceleration;
        isSprinting = false;
        currentSpeed = 0f;
    }
}