using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    //Variable used to store and adjust the player's movement speed
    public float speed;

    //Variable used to store the player's mouse position
    private Vector3 _mousePos;

    //Reference to the player
    private GameObject _playerRef;

    private Ray _rayCast;

    // Start is called before the first frame update
    void Start()
    {
        _playerRef = GetComponent<GameObject>();
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

        }
    }
}
