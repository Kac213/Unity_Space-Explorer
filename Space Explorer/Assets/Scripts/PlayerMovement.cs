using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 5.0f;
    float rotationSpeed = 360.0f;

    float shipBoundaryRadius = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotate = transform.rotation;
        float z = rotate.eulerAngles.z;
        z -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        rotate = Quaternion.Euler(0, 0, z);
        transform.rotation = rotate;

        Vector3 movement = transform.position;

        Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        movement += rotate * velocity;


        //// EXPERIMENTAL
        //// y - axis
        //Vector3 forward = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        //movement += rotate * forward;

        //if (movement.y + shipBoundaryRadius > Camera.main.orthographicSize)
        //{
        //    movement.y = Camera.main.orthographicSize - shipBoundaryRadius;
        //}
        //else if (movement.y - shipBoundaryRadius < -Camera.main.orthographicSize)
        //{
        //    movement.y = -Camera.main.orthographicSize + shipBoundaryRadius;
        //}

        //// x-axis
        //float screenRatio = (float)Screen.width / (float)Screen.height;
        //float widthOrtho = Camera.main.orthographicSize * screenRatio;
        //if (movement.x + shipBoundaryRadius > widthOrtho)
        //{
        //    movement.x = widthOrtho - shipBoundaryRadius;
        //}
        //else if (movement.x - shipBoundaryRadius < -widthOrtho)
        //{
        //    movement.x = -widthOrtho + shipBoundaryRadius;
        //}


        transform.position = movement;
    }
}
