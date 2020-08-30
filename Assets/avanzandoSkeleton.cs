using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avanzandoSkeleton : MonoBehaviour
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
}
