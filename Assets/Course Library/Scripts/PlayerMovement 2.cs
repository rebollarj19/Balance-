using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float rotationSpeed;
    private GameObject focalPoint;
    private Rigidbody island;

    // Start is called before the first frame update
    void Start()
    {
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.back * horizontalInput * rotationSpeed, Space.World);
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
}
