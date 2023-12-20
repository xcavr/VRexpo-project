using UnityEngine;

public class continousrotaton : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed of rotation as needed

    void Update()
    {
        // Rotate the object continuously around its up axis
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
