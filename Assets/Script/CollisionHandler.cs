using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "friendly":
                Debug.Log("This thing is friendly");
                break;

            case "fuel":
                Debug.Log("You have picked up the fuel");
                break;

            case "Finish":
                Debug.Log("You have reached the end point");
                break;

            default:
                Debug.Log("You blew up");
                break;
        }

    }
}