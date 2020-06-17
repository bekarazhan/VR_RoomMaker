using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchToEdit : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    public Slider _sizeSlider;
    public Slider _rotateSlider;
    GameObject EditingObject;
    
    bool _click = false;


    void Start()
    {
        
    }
   /* private void Select()
    {
        if (_isSelected) { gameObject.tag = "Selected"; }
        else { gameObject.tag = "NotSelected"; }
    }
    */
    

    // Update is called once per frame
    void Update()
    {
        if (_click)
        {
            if (Input.GetMouseButtonUp(0))
            {
                ShotAndColor();
            }

        }
        else 
        {
            if (Input.GetMouseButtonDown(0))
            {
                _click = true;
            }
        }
       
    }

    public void ScaleSlider() 
    {
        if (EditingObject) 
        {
            EditingObject.transform.localScale = new Vector3 
                (_sizeSlider.value, _sizeSlider.value, _sizeSlider.value);
        }
    }
    public void RotateSlider()
    {
        if (EditingObject)
        {
            EditingObject.transform.rotation = Quaternion.Euler(0, _rotateSlider.value * 360, 0);
        }
    }
    private void ShotAndColor()
    {
        
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
            Debug.Log(hit.transform.gameObject);
            if (hit.transform.gameObject.tag == "InteriorElement")
            {        
                
                if (hit.transform.gameObject != EditingObject)
                {
                    if (EditingObject)
                    {
                        var tr = EditingObject.transform;
                        var plane = tr.GetChild(tr.childCount - 1);
                        var ren = plane.transform.GetComponent<Renderer>();
                        if (ren != null)

                        {
                            ren.enabled = false;

                        }
                    }
                    EditingObject = hit.transform.gameObject;
                    ColorObject(hit.transform.gameObject);
                    SyncSize();
                }
                else
                {
                    EditingObject = null;
                    var tr = hit.transform;
                    var plane = tr.GetChild(tr.childCount - 1);
                    var ren = plane.transform.GetComponent<Renderer>();
                    if (ren != null)

                    {
                        ren.enabled = false;

                    }

                }


                

            }
            }


        
    }

    private void ColorObject(GameObject _object)
    {

        if (_object != null) 
        { 
        var selection = _object.transform;

            //Debug.Log(hit.transform.gameObject.name);
            var plane = selection.GetChild(selection.childCount - 1);
             var selectionRenderer = plane.GetComponent<Renderer>();

            if (selectionRenderer != null)

            {
                selectionRenderer.enabled = true;
            
            }
            
            /*foreach (Transform child in selection)
        {

            if (child.name == "SelectingPlane")
            {
                var selectionRenderer = child.GetComponent<Renderer>();
               
                    if (selectionRenderer != null)
               
                    {
                    selectionRenderer.enabled = _isSelected;
                    
               
                    }
           
                }
       
            }
            */
        }

    }

    




    void SyncSize() 
    {
        if (EditingObject)
        {
            _sizeSlider.value = EditingObject.transform.localScale.x;
            //_rotateSlider.value = EditingObject.transform.rotation.y;

        }
    }



}
