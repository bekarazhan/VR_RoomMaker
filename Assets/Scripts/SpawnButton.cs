using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public GameObject SpawnPref;
    public GameObject plane;
    private GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
      /*  obj = Instantiate(SpawnPref, transform.position, transform.rotation);
        obj.transform.localScale = new Vector3(Measures.length, 0.02f, Measures.length);
        obj.transform.parent = transform.parent;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
