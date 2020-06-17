using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class VRButton : MonoBehaviour
{
    //GetComponent<Button>().onClick.Invoke();
    public float totaltime = 2;
    bool gvrStatus;
    public float gvrTimer;
    public Button bt;
    
    //public GameObject plane;
   /* GameObject plane;
    Button button;*/
    

    // Start is called before the first frame update
    void Start()
    {

        /*bt = GetComponent<Button>();
        plane = transform.parent.gameObject;
        button = GetComponent<Button>();*/
       
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
          bt.onClick.Invoke();
            
            gvrTimer = 0;

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
