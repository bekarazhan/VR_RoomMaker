using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DBobjects : MonoBehaviour
{
    // Start is called before the first frame update
    public static List<GameObject> items = new List<GameObject>();
    public List<GameObject> _objects = new List<GameObject>();
    void Start()
    {
        foreach (var i in _objects)
        {
            items.Add(i);
        }
    }
}
