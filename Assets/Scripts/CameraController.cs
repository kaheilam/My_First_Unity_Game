using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // camera focus on player, we use transform bcoz for the player, we basically focus on the position
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = PlayerController.instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // use vector3 bcoz of XYZ
        // player's x and y position, and camera's z position
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }
}
