using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{

    public GameObject player; 

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerController.instance == null)
        {
            // if there is no player shows in scene, then instantiate the player into the world
            Instantiate(player);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
