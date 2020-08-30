using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float speed = 5f;
    [SerializeField]
    float maxSpeed = 6f;
    [SerializeField]
    float jumpPower = 10.2f;
    bool jumping;
    private Rigidbody2D rigid2d;
    private Animator animator;
    
    private bool grounded;

    public bool Grounded {
        get { return grounded; }
        set { grounded = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Math.Abs(rigid2d.velocity.x));
        animator.SetBool("Grounded", grounded);

        if(Input.GetKeyDown(KeyCode.Space) && grounded){
            jumping = true;
        }

    }

    void FixedUpdate() {

        Vector3 fixedVelocity = rigid2d.velocity;
        fixedVelocity.x *= 0.75f;

        if(grounded){
            rigid2d.velocity = fixedVelocity;
        }

        float movement = Input.GetAxis("Horizontal");
        
        rigid2d.AddForce(Vector2.right * speed * movement);
        
        float limitedSpeed = Mathf.Clamp(rigid2d.velocity.x, -maxSpeed, maxSpeed);
        rigid2d.velocity = new Vector2(limitedSpeed, rigid2d.velocity.y);


        if(movement > 0.1f){
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if(movement < -0.1f){
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }

        if(jumping){
            rigid2d.velocity = new Vector2(rigid2d.velocity.x, 0);
            rigid2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jumping = false;
        }

    }

    void OnCollisionEnter2D(Collision2D other){
        if(other.transform.CompareTag("Hurt")){
            Morir();
        }
    }

    void Morir(){
        animator.SetBool("IsDead", true);
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex ) ;
    }

}
