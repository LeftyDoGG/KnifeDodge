using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public bool moveRight;
    private float speed = 2f;
    void Start()
    {
        
    }


    void Update()
    {
        Move();
    }

    void Move()
    {
        if (moveRight)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
        }
        else
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
    }
}
