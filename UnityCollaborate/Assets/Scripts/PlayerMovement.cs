using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 10f;
    
    [SerializeField]
    private float jumpForce  = 10f;
    //public float sprint = 20f;
    private float movementX;
    private float movementY;

    void Start()
    {
        
    }

    
    void Update()
    {
        PlayerMovementKeyboard();
    }

    public void PlayerMovementKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(movementX, movementY, 0) * movementSpeed * Time.deltaTime;
    }

}
