using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float currentTime = 0;
    public float destroyTime = 3f; 
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        Vector2 direction = Vector2.up * speed * Time.deltaTime; 
        rb.AddForce(direction, ForceMode2D.Impulse);

        DisableOnTime();

        Debug.Log(currentTime);
    }

    private void DisableOnTime()
    {
        if(currentTime >= destroyTime)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        currentTime = 0;
    }
}
