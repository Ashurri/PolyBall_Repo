using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPowerUp : MonoBehaviour
{
    BoxCollider compoCollider;
    public SphereCollider coll_Player;
    public GameObject obj_Player;

    bool isEquipped = false;

    private void OnCollisionEnter(Collider _other)
    {
        Debug.Log("pepega");
        /*if (_other.gameObject.tag == obj_Player.tag)
        {
            Debug.Log("retard");
            this.transform.SetParent(obj_Player.transform);
            
        }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        obj_Player = GameObject.Find("Player");
        coll_Player = obj_Player.GetComponent<SphereCollider>();
        compoCollider = this.GetComponent<BoxCollider>();
    }
    
}
