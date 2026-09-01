using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    float mainThrust = 100f;
    float RotationThrust = 10f;
    Rigidbody rb;
    void start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

    }
    void Processthrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * Time.deltaTime * mainThrust);
        }
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(RotationThrust);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-RotationThrust);
        }
    }
    void ApplyRotation(float rotation)
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotation);
    }
}
