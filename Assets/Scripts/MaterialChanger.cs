using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaterialChanger : MonoBehaviour
{
    
    public int i = 0;
    public Material[] mats;
    public static Material current;
    //public GameObject VRcircle;
    //GameObject circle;
    
     
    //public GameObject plane;

    //MeshRenderer planemr;
    Renderer CylMR;
    // = new Material [5]
    // Start is called before the first frame update
    void Start()
    {
        //  planemr.material = mats[i];
        MatChange();
        // CircleSpawn();
        for (int i =0;i< mats.Length;i++) 
        { 
            mats[i].mainTextureScale = new Vector2(Measures.length, Measures.height); 
        }
        

    }

   

    /*
private void CircleSpawn()
{
   circle = Instantiate(VRcircle, transform.position, transform.rotation);
   circle.transform.localScale = new Vector3(Measures.length, 0.02f, Measures.length);
}
*/
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Left() 
    {
        
        i--;
        if (i<0) { i = mats.Length-1; }
        SetMaterial(i);
    }   
    public void Right()
    {
        i++;
        if (i > mats.Length-1) { i = 0; }
        SetMaterial(i);
    }
    private void SetMaterial(int i) 
    {
        current = mats[i];
        CylMR.material = current;
    }

    private void MatChange()
    {
        current = mats[i];
        CylMR = GetComponent<Renderer>();
        CylMR.material = current;
        
        Debug.Log(mats.Length);
    }
}
