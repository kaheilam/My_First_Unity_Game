using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // physic body
    public Rigidbody2D theRB;

    public int value;
    public float moveSpeed;
    public Animator myAnim;

    // PlayerController is the reference to the script
    // instance = the main char that the player control
    public static PlayerController instance;

    // switch area
    public string areaTransitionName;




    // Start is called before the first frame update
    void Start()
    {
        // (only qualify when the game first start) check to see if the instance is empty
        if (instance == null)
        {
            // instance has to be equal to this script
            instance = this;
        }
        else
        {
            // destrop duplicate instance
            Destroy(gameObject);
        }

        // when we load a new scene, don't destroy the gameObject
        // gameObject = the object that the script is attach to (in this case, it is player)
        DontDestroyOnLoad(gameObject);
    }




    // Update is called once per frame
    void Update()
    {
        // movespeed * the player input on left/right
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * moveSpeed;

        // set moveX & moveY as the instance's velocity (player's input)
        myAnim.SetFloat("moveX", theRB.velocity.x);
        myAnim.SetFloat("moveY", theRB.velocity.y);


        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }

        
    }
}
