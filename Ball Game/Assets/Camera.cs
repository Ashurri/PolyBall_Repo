using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject Player;
    Vector3 offset;

    void Start()
    {
        Player = GameObject.Find("PlayerBall");
        offset = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        float newXPosition = Player.transform.position.x + offset.x;
        float newZPosition = Player.transform.position.z + offset.z;

        transform.position = new Vector3(newXPosition, transform.position.y, newZPosition);
    }
}
