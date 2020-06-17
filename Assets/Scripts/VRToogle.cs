using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VRToogle : MonoBehaviour
{
    // Start is called before the first frame update
    //public static bool toogle = true;
    //public Button but;
    public Camera _topcamera;
    public Camera _VRcamera;
    //public GameObject _vrmode;
    public GameObject _gvrevent;
    public GameObject _gvremulator;
    public GameObject _eventsystem;
    public Canvas gr;
    public GameObject _vrtoogle;

    void Start()
    {
        //OnOffVR();
       // gr = gameObject.GetComponent<GraphicRaycaster>();

    }
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.X))
        {
            OnOffVR();
            Debug.Log("GG");
        }*/
    }
    public IEnumerator ActivateVR(string VR)
    {
        XRSettings.LoadDeviceByName(VR);
        yield return null;
        XRSettings.enabled = true;
    }

    public IEnumerator DeactivateVR(string VR)
    {
        XRSettings.LoadDeviceByName(VR);
        yield return null;
        XRSettings.enabled = false;
    }

    public void OnOffVR() 
    {

        if (_VRcamera.gameObject.activeSelf) 
        {
            _eventsystem.SetActive(true);
            gr.enabled = true;
            _VRcamera.tag = "Untagged";
            _VRcamera.gameObject.SetActive(false);
            _topcamera.gameObject.SetActive(true);
            _topcamera.tag = "MainCamera";

            // _vrmode.gameObject.SetActive(true);            

            _gvremulator.SetActive(false);
            _gvrevent.SetActive(false);

            StartCoroutine(ActivateVR("None"));
            _vrtoogle.SetActive(false);
        }
        else 
        {
            
           // StartCoroutine(DeactivateVR("None"));

            _eventsystem.SetActive(false);
            gr.enabled = false;
           
            _topcamera.tag = "Untagged";
            _topcamera.gameObject.SetActive(false);
            _VRcamera.gameObject.SetActive(true);
            _VRcamera.tag = "MainCamera";
            _gvremulator.SetActive(true);
            _gvrevent.SetActive(true);

            // _vrmode.gameObject.SetActive(true);            



            StartCoroutine(ActivateVR("Cardboard"));
            _vrtoogle.SetActive(true);
            //Instantiate(_gvremulator, transform.position, transform.rotation);
            //Instantiate(_gvrevent, transform.position, transform.rotation);
        }
        
    }
}/* StartCoroutine(DeactivateVR("cardboard"));
            //_vrmode.gameObject.SetActive(false);
            _VRcamera.tag = "Untagged";
            _VRcamera.gameObject.SetActive(false);
            _topcamera.gameObject.SetActive(true);
            _topcamera.tag = "MainCamera";
            StartCoroutine(ActivateVR("None"));*/


// StartCoroutine(DeactivateVR("cardboard"));
