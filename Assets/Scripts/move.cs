using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.U2D;

public class move : MonoBehaviour
{

    new Rigidbody2D rigidbody2D;
    
    float speedMod = 3f;


    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        // spriteRenderer = GetComponent<SpriteRenderer>();
        // pixelPerfectCamera = GameObject.FindObjectOfType<PixelPerfectCamera>();
    }

    void Update()
    {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
        transform.position += movement*Time.deltaTime*speedMod;
    }
}