using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] float mainThrust = 100f;
    [SerializeField] float RotationThrust = 1f;
    Rigidbody rb;
    AudioSource audiosource;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(Vector3.up * Time.deltaTime * mainThrust);
            if (!audiosource.isPlaying)
            {
                audiosource.Play();
            }
        }
        else
        {
            audiosource.Stop();
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
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * Time.deltaTime * rotation);
        rb.freezeRotation = false;
    }
}
