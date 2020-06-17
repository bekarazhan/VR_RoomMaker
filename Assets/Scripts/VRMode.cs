using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;

public class VRMode : MonoBehaviour
{

    // Start is called before the first frame update
    public void Start()
    {
        if(SceneManager.GetActiveScene().name == "CreatedRoom")
        { /*
            XRSettings.LoadDeviceByName("None"); }
            XRSettings.LoadDeviceByName("cardboard");
            XRSettings.enabled = true;
            */
        }
        StartCoroutine(ActivateVR("cardboard"));


       
    }

    public IEnumerator ActivateVR(string VR)
    {
        XRSettings.LoadDeviceByName(VR);
        yield return null;
        XRSettings.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
