using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        switch (other.gameObject.tag)
        {
        case "Friendly":
            Debug.Log("This thing is friendly");
            break;
        case "Finish":
            Debug.Log("Congrats! Level complete");
            break;
        case "Fuel":
            Debug.Log("You picked up some Fuel!");
            break;
        default: 
            Debug.Log("You blew up :(");
            break;
        }
    }
}
