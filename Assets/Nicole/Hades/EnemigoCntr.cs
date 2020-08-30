using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class EnemigoCntr : MonoBehaviour
{
    public float vel = -1f;
    Rigidbody2D rgb;


    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = new Vector2(vel, 0);
        rgb.velocity = v;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Flip();
    }

    void Flip()
    {
        vel *= -1;
        var s = transform.localScale;
        s.x *= -1;
        transform.localScale = s;
    }
}
