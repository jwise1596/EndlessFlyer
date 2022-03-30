using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    public Text scoreText;
    private float score;
    
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pickup")
        {
            score += 1;
            scoreText.text = ((int)score).ToString();
        }
    }
}

