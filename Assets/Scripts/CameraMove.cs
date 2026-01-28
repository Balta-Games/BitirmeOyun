using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    private bool invertY = true;
    public Transform lookAt;
    public float distance;
    private Vector2 input;
    [SerializeField] private MouseSensivity sensivity;
    private CameraRotation cameraRotation;
    [SerializeField] private CameraAngle cameraAngle;

    void Awake()
    {
        distance = Vector3.Distance(transform.position, lookAt.position);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.eulerAngles = new Vector3(cameraRotation.x, cameraRotation.y, 0);
        transform.position = lookAt.position - transform.forward * distance;
    }

    private void Update()
    {
        cameraRotation.y += input.x * sensivity.horizontal * Time.deltaTime;
        cameraRotation.x += (invertY ? -1f : 1f) *  input.y * sensivity.vertical * Time.deltaTime;
        cameraRotation.x = Mathf.Clamp(cameraRotation.x, cameraAngle.min, cameraAngle.max);
    }

    public void Look(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
    }
}

[Serializable]
public struct MouseSensivity
{
    public float horizontal;
    public float vertical;
}

public struct CameraRotation
{
    public float x;
    public float y;
}

[Serializable]
public struct CameraAngle
{
    public float min;
    public float max;
}