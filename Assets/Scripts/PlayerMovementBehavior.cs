using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    //Variable used to store and adjust the player's movement speed
    public float speed;
    //Variable used to store the player's mouse position
    private Vector3 _mousePos;
    //Ray variable used to represent a ray to the mouse
    private Ray _mouseRay;
    //Reference to the rigidbody
    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //A new vector3 "direction" thats x is set to "Horizontal" and y is set to "Vertical"
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //If the Left mouse button is pressed execute code
        if (Input.GetKey(KeyCode.Mouse0))
        {
            //Sets the _mousePos variable to be the mouse position
            _mousePos = Input.mousePosition;
            //Sets the _mouseRay variable to the main camera and calls the ScreenPointToRay function with _mousePos passed in
            _mouseRay = Camera.main.ScreenPointToRay(_mousePos);
            //Create a plane at the player's position
            Plane playerPlane = new Plane(Vector3.up, transform.position);
            //Find how far from the camera the ray intersects the plane;
            float rayDistance = 0.0f;
            playerPlane.Raycast(_mouseRay, out rayDistance);
            //Sets targetpoint to be the ray distance to the plane
            Vector3 targetpoint = _mouseRay.GetPoint(rayDistance);
            //Get the direction
            direction = (targetpoint - transform.position).normalized;
        }
        //Velocity variable is set to the direction scaled by the player's speed
        Vector3 velocity = direction * speed;
        //Moves the rigidbody to position
        characterController.SimpleMove(velocity);
    }
}
