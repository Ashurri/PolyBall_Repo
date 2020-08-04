using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_CubePower : MonoBehaviour
{
    private Rigidbody rigidBody;
    public BoxCollider boxCollider;
    private Script_PlayerController playerController;
    public GameObject playerGameObject;

    private void OnCollisionEnter(Collision _collision)
    {
        if (_collision.collider.tag == "Player")
        {
            playerGameObject = GameObject.FindWithTag("Player");
            playerController = playerGameObject.GetComponent<Script_PlayerController>();
            this.transform.SetParent(playerGameObject.transform);
            rigidBody.isKinematic = true;
            //temporary fix
            //find a way so the powerup does not collide with the player
            boxCollider.enabled = false;

            //do something
            playerController.ijumpMax++;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = this.GetComponent<Rigidbody>();
        boxCollider = this.GetComponent<BoxCollider>();
    }
}
