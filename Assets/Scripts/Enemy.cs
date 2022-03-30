using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Borders"||collision.tag == "Projectile")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}