using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody2D BoyBody;
    private float jumpforce = 5f;

    void Start()
    {
        BoyBody = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Jump();
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BoyBody.velocity = new Vector2(BoyBody.velocity.x, jumpforce);
        }
    }
     void OnTriggerEnter2D(Collider2D Target)
    {
        if (Target.tag == "Knife")
        {
            Time.timeScale = 0f;
        }
    }
}
