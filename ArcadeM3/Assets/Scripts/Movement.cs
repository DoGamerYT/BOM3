using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;      
    public float jumpForce = 7f;
    public LayerMask groundLayer;     

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        CheckGrounded();
        



        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal"); 
        float moveZ = Input.GetAxis("Vertical");   

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ) * moveSpeed;
        Vector3 newVelocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);
        

        rb.velocity = newVelocity;
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
    }

    void CheckGrounded()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);
    }

    void TurnPlayer()
    {
        transform.position = new Vector3(-1.8f, 1.2f, 0.15f);
        transform.Rotate(0.0f, 10.0f, 0.0f);
        transform.Rotate(moveSpeed, 10.0f, 50.0f);

    }

    void PlayerCam()
    {
       
    }
}
