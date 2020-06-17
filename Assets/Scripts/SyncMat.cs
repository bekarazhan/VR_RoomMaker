using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncMat : MonoBehaviour
{
    
    public GameObject matobj;
    private MeshRenderer matmat;
    GameObject plane;
    // Start is called before the first frame update
    void Start()
    {
        plane = GetComponent<GameObject>();
        matmat = plane.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        matmat.material = MaterialChanger.current;
    }
}
