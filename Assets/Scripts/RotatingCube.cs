using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCube : MonoBehaviour
{
    GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        go = transform.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        go.transform.Rotate(new Vector3(0,25,0) * Time.deltaTime);
    }
}
