using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Gvr;
    void Start()
    {
        Instantiate(Gvr,transform.position,transform.rotation,transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
