using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsPool : MonoBehaviour
{
    public GameObject projectile;
    List<GameObject> bullets;
    public int totalRounds = 10;

    private void Awake()
    {
      
    }

    void Start()
    {
        bullets= new List<GameObject>();

        GameObject temp;
        for (int i = 0; i < totalRounds; i++)
        {
            temp = Instantiate(projectile,transform); 
            temp.SetActive(false);
            bullets.Add(temp);
            

        }
       
    }

    
    void Update()
    {
        
        
    }

    public GameObject getBullets()
    {
        for (int i = 0; i < totalRounds; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                bullets[i].SetActive(true);
                return bullets[i];
            }
        }
        return null;
    }
}
