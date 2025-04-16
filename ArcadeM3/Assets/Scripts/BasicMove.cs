using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BasicMove : MonoBehaviour
{

        
    [SerializeField] private float speed = 50f;
    [SerializeField] private float rotSpeed = 100f;
       

    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

       
    void Update()
    {
        // TurnPlayer();
            

        float move = Time.deltaTime * speed * Input.GetAxis("Vertical");
        rb.velocity = rb.transform.forward * move;
        float rot = Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        rb.transform.Rotate(new Vector3(0, rot, 0));

    }

    void TurnPlayer()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ) * speed;
        Vector3 newVelocity = new Vector3(moveDirection.x, rb.velocity.y, moveDirection.z);
        transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime, 0));

        rb.velocity = newVelocity;
    }
    
}
