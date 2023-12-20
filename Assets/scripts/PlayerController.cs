using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float Turnspeed = 25.0f;
    private float Horizondalinput;
    private float Verticalinput;
    public Transform cameraTransform; // Reference to the camera's transform

    // Start is called before the first frame update
    void Start()
    {
        if (cameraTransform == null)
        {
            Debug.LogWarning("Camera transform is not assigned. Please assign the camera's transform in the Inspector.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Verticalinput = Input.GetAxis("Vertical");
        Horizondalinput = Input.GetAxis("Horizontal");

        // Move the player object forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Verticalinput);

        // Rotate the player object around its Y-axis
        transform.Rotate(Vector3.up, Time.deltaTime * Turnspeed * Horizondalinput);

        // Rotate the camera to follow the player's rotation
        if (cameraTransform != null)
        {
            cameraTransform.rotation = transform.rotation;
        }
    }
}
