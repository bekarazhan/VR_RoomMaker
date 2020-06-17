using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFixer : MonoBehaviour
{
    // Start is called before the first frame update
   

    // Start is called before the first frame update
    void Start()
    {
       
       transform.localScale = new Vector3(Measures.width/10, 0.02f, Measures.length / 10 );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
