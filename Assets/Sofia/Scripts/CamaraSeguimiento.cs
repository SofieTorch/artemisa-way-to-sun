using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguimiento : MonoBehaviour
{
    public GameObject follow = default;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float posX = follow.transform.position.x + 7f;
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
