using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerController : MonoBehaviour
{
    Rigidbody rigidBody;
    SphereCollider Collider;
    public int ijumpMax;
    public int ijumpCount;
   
    private Vector3 currentVelocity;
    private Vector3 maximumVelocity;

    public Vector3 jumpForce;
    public Vector3 movementForce;

    //Function for all Input process's
    void processInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(movementForce);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(-movementForce);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ijumpCount != ijumpMax)
            {
                rigidBody.AddForce(jumpForce);
                ijumpCount++;
            }
        }
    }

    //OnCollisionEnter Event triggers everytime the rigidbody collides
    //with another rigidbody/collisionbox
    private void OnCollisionEnter(Collision _collision)
    {
        if (_collision.collider.tag == "Ground")
        {
            ijumpCount = 0;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        currentVelocity = rigidBody.velocity;
        rigidBody = this.GetComponent<Rigidbody>();
        Collider = this.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        processInput();
        Debug.Log(currentVelocity);
    }
}
