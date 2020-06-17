using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScaleFixer : MonoBehaviour
{
    // Start is called before the first frame update


    // Start is called before the first frame update
    void Start()
    {

        transform.localScale = new Vector3(Measures.width / 1000, Measures.length / 1000, 0.02f);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
