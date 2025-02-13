﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSystem : MonoBehaviour
{
    [SerializeField] GameObject heartPrefab;
    public void DrawHeart(int hearts, int maxhearts)
    {
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        for(int i =0;i<maxhearts; i++)
        {
            if (i + 1 <= hearts)
            {
                GameObject heart = Instantiate(heartPrefab, transform.position, Quaternion.identity);
                heart.transform.parent = transform;
            }
           
            
        }
    }

}
