using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_DoubleJump : MonoBehaviour
{
    public Rigidbody rigid;
    public GameObject player;
    public BoxCollider Collider;

    private Script_PlayerController playerController;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            this.transform.SetParent(player.transform);
            Collider.enabled = false;
            rigid.isKinematic = true;
            playerController = player.GetComponent<Script_PlayerController>();
            playerController.ijumpMax++;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
        Collider = this.GetComponent<BoxCollider>();


        player = GameObject.FindWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
