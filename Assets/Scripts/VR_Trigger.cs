using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VR_Trigger : MonoBehaviour
{
    public GameObject plane;
    public float totaltime = 2;
    bool gvrStatus;
    public float gvrTimer;
    public  GameObject matmenu;
    GameObject matmenuprivate;
    private bool prevmenu = false;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
            
        }

        

        if (gvrTimer > totaltime)
        {
            truefalse();
            gvrTimer = 0;
            
            }
        
    }

    void truefalse()
    {
        if (prevmenu == false)
        { prevmenu = true; }
        else { prevmenu = false; }

        switch (prevmenu)
        {
            case true:
                matmenu.SetActive(true);
                //matmenuprivate = Instantiate(matmenu, transform.position, transform.rotation* new Quaternion(90,0,0,0)); matmenuprivate.transform.localScale = new Vector3(0.1f,0.1f,0.1f);
                break;
            case false:
                matmenu.SetActive(false);
                //Destroy(matmenuprivate);
                break;
            default:
                break;
        }
    }

        public void GvrOn()
    {
        gvrStatus = true;
    }
    public void GvrOff()
    {
        gvrStatus = false;
        gvrTimer = 0;

    
    }
}