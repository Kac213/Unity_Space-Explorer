using UnityEngine;
using UnityEngine.UIElements;

public class ForwardMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float maxSpeed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = transform.position;
        Vector3 forward = new Vector3(0, maxSpeed * Time.deltaTime, 0);
        movement += transform.rotation * forward;
        transform.position = movement;
    }
}
