using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class DrawSendScript : MonoBehaviour
{
    [SerializeField]
    Tranform from;
    [SerializeField]
    Transform to;

    void OnDrawGizmosSelected(){
        if(from != null && to != null){
            Gizmos.color = COlor.cyan;
            Gizmos.DrawLine(from.position, to.position);
        }
    }
}
