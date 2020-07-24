using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PlayerController : MonoBehaviour
{
    Rigidbody rigidBody;
    SphereCollider Collider;

    public Vector3 movementForce;
    void processInput()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rigidBody.AddForce(movementForce);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rigidBody.AddForce(-movementForce);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
         rigidBody = this.GetComponent<Rigidbody>();
         Collider = this.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        processInput();
    }
}
