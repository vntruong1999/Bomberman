﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    // Number of frame
    int numOfFrame = 120;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numOfFrame -= 1;

        if (numOfFrame == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
