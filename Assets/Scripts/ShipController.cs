using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float shipSpeed = 5.0f;
    public BulletsPool bulletPool;
    public Transform torret1;
    public Transform torret2;
   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = Input.GetAxis("Horizontal");

        transform.Translate(moveDirection * shipSpeed * Time.deltaTime, 0.0f, 0.0f);

        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            GameObject bullet = bulletPool.getBullets();
            bullet.transform.position = torret1.transform.position;
            bullet.transform.rotation= torret1.transform.rotation;
         
        }
    }
}
