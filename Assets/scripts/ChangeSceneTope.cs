using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class ChangeSceneTope : MonoBehaviour
{

    [SerializeField]
    GameObject artemisa = default;
    [SerializeField]
    int numScene;

    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject == artemisa){
            SceneManager.LoadScene(numScene);
        }
    }
}
