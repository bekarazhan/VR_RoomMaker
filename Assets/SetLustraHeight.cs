﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLustraHeight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,Measures.height*10,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
