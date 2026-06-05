using System;
using System.Collections;
using NUnit.Framework;
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
    [SerializeField] private AxeHitbox axeHitbox;
    private bool isRolling;

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
        float targetSpeed = 0f;

        if (!isAttacking && !isBlocking && !isRolling)
        {
            targetSpeed = movement.isSprinting ? movement.speed * movement.multiplier : movement.speed;
        }

        movement.currentSpeed = Mathf.MoveTowards(movement.currentSpeed, targetSpeed, movement.acceleration * Time.deltaTime);

        Vector3 horizontal = direction * movement.currentSpeed;
        Vector3 finalMove = horizontal;

        finalMove.y = velocity;

        characterController.Move(finalMove * Time.deltaTime);
    }
    private void ApplyRotation()
    {
        if(isAttacking || isBlocking || isRolling) return;

        if (input.sqrMagnitude == 0f) return;

        direction = Quaternion.Euler(0, mainCamera.transform.eulerAngles.y, 0) * new Vector3(input.x, 0, input.y);

        Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 500f);
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
    public void Jump(InputAction.CallbackContext context)
    {
        if(!context.started || isAttacking || isRolling) return;
        if(!characterController.isGrounded && remainingJumpNumber <= 0) return;
        else if(characterController.isGrounded) remainingJumpNumber = maxJumpNumber;


        animator.applyRootMotion = false;
        velocity += jumpHeight;
        remainingJumpNumber--;
        animator.SetTrigger("Jumped");
        PlayerAnalytics.Instance.AddJump();
    }
    public void Move(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
        direction = new Vector3(input.x, 0, input.y);
    }
    public void Attack(InputAction.CallbackContext context)
    {
        if(isAttacking || isRolling) return;

        animator.applyRootMotion = true;
        isAttacking = true;
        animator.SetTrigger("isAttacked");
        PlayerAnalytics.Instance.AddAttack();
        axeHitbox.SetActive(true);
    }
    public void closeAxeCollider()
    {
        axeHitbox.SetActive(false);
    }
    public void EndAttack()
    {
        isAttacking = false;
        axeHitbox.SetActive(false);
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
    public void Roll(InputAction.CallbackContext context)
    {
        if (!context.started || isRolling || isAttacking || isBlocking) return;

        animator.applyRootMotion = true;
        isRolling = true;
        animator.SetTrigger("Rolled");
        PlayerAnalytics.Instance.AddRoll();
    }
    public void changeHeight()
    {
        if(characterController.height == 1.85f)
            StartCoroutine(ChangeHeightCoroutine(0.7f, 0.5f));
        else if(characterController.height == 0.7f)
            StartCoroutine(ChangeHeightCoroutine(1.85f, 0.5f));
    }

    private IEnumerator ChangeHeightCoroutine(float targetHeight, float duration)
    {
        float startHeight = characterController.height;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.deltaTime;
            characterController.height = Mathf.Lerp(startHeight, targetHeight, elapsed / duration);
            yield return null;
        }

        characterController.height = targetHeight; // son değeri garantiye almak için
    }
    public void endRoll()
    {
        isRolling = false;
    }
    public void closeRootMotion()
    {
        animator.applyRootMotion = false;
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