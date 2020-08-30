using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrounded : MonoBehaviour
{

    private PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            player.Grounded = true;
        }
        if(other.gameObject.tag == "Platform"){
            player.Grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            player.Grounded = false;
        }
        if(other.gameObject.tag == "Platform"){
            player.Grounded = false;
        }
    }
}
