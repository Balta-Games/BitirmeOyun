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
    public bool invertY = false;

    void Start()
    {
        
    }
    // Update is called once per frame
    void LateUpdate()
    {

        currentX += Input.GetAxis("Mouse X") * (sensivity * 2) * Time.deltaTime;
        currentY += Input.GetAxis("Mouse Y") * (sensivity * 2) * Time.deltaTime;

        currentY = Mathf.Clamp(currentY, YMin, YMax);

        Vector3 Direction = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = lookAt.position + rotation * Direction;

        transform.LookAt(lookAt.position);

     

    }
}
