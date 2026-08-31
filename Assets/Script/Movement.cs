using UnityEngine;

public class Movement : MonoBehaviour
{
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    void ProcessThrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("You have pressed space bar ");
        }
    }
    void ProcessRotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotating Left");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotating Right");
        }
    }
}
