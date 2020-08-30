using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Coin : MonoBehaviour
{
    [SerializeField]
    Text coinsCounter = default;
    [SeralizeField]
    GameObject player = default;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.coins += 1;
            coinsCounter.text = player.coins.ToString();
            GetComponent<SpriteRenderer>().enabled = false;
            
        }
    }
}
