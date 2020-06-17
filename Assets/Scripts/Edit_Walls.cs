using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edit_Walls : MonoBehaviour
{
    private LineRenderer lr;
    public GameObject corner;
    private SphereCollider sc;
    private Vector2 mousePos;
    private bool m = false;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        sc = corner.GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Ray castPoint = Camera.main.ScreenPointToRay(mouse);
            
            if (Physics.Raycast(castPoint, out hit))
            {
                m = true;
               
                Debug.Log(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane)));
            }
            

        }
        if (Input.GetMouseButtonUp(0))
        {
            m = false;

        }

        if (m)
        {
            hit.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 60));
        }



    }

    private void OnMouseDown()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (sc.bounds.Contains(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 60))) { Debug.Log("SUKA"); }
    }
}
