using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private const float YMin = -50.0f;
    private const float YMax = 50.0f;
    public Transform lookAt;
    public float distance = 2.0f;
    private float currentX = 0;
    private float currentY = 0;
    public float sensivity = 100.0f;
    private bool invertY = true;

    // Update is called once per frame
    void LateUpdate()
    {
        // Getting Mouse Input
        currentX += Input.GetAxis("Mouse X") * (sensivity * 2) * Time.deltaTime;
        currentY += (invertY ? -1f : 1f) * Input.GetAxis("Mouse Y") * (sensivity * 2) * Time.deltaTime;
        currentY = Mathf.Clamp(currentY, YMin, YMax);

        // Calculating Camera Position
        Vector3 Direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = lookAt.position + rotation * Direction;

        transform.LookAt(lookAt.position);
    }
}
