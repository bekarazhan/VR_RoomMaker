using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeightWindow : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(0,Measures.height*10-10,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
