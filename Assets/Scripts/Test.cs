using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 90f; // degrees per second
    
    void Update()
    {
        // Rotate the cube around its Y-axis (vertical spin)
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        
        // Alternatively, for rotation on all axes:
        // transform.Rotate(rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime, rotationSpeed * Time.deltaTime);
    }
}
