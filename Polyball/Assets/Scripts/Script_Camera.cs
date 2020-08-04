using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Camera : MonoBehaviour
{
    private Vector3 startpos;
    public GameObject obj_Player;

    float f_ZoffsetDistance;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        f_ZoffsetDistance = startpos.z - obj_Player.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = new Vector3(obj_Player.transform.position.x, obj_Player.transform.position.y, f_ZoffsetDistance);
        transform.position = newpos;
    }
}
