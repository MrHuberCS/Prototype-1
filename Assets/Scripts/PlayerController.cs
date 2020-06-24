using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float carSpeed = 25.0f;
    [SerializeField]
    private float turnSpeed = 5.0f;
    [SerializeField]
    private float horizontalInput;
    [SerializeField]
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * forwardInput * Time.deltaTime);
    }
}
