using UnityEngine;
using System.Collections;

public class colorpicker : MonoBehaviour {

    public GameObject ColorPickedPrefab;
    private VrColorPickerTriangle CP;
    private bool isPaint = false;
    private GameObject go;
    Material mat;
    int _childcount;

    public float totaltime = 2;
    bool gvrStatus;
    public float gvrTimer;

    void Start()
    {
        mat = transform.GetChild(0).GetComponent<MeshRenderer>().material;
        _childcount =  transform.childCount;
    }

    void Update()
    {
        if (isPaint)
        {
            mat.color = CP.TheColor; 
           
        }

        if (gvrStatus)
        {
            gvrTimer += Time.deltaTime;
        }

        if (gvrTimer > totaltime)
        {

            if (isPaint)
            {
                StopPaint();
            }
            else
            {
                StartPaint();
            }
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
    

    private void StartPaint()
    {
        go = (GameObject)Instantiate(ColorPickedPrefab, transform.position + Vector3.up * 10f, Quaternion.identity);
        go.transform.localScale = Vector3.one * 5.3f;
        go.transform.LookAt(Camera.main.transform);
        go.transform.position += (Camera.main.transform.position- go.transform.position)*0.5f;
        CP = go.GetComponent<VrColorPickerTriangle>();
        CP.SetNewColor(mat.color);
        //for (int i = 0;i<_childcount;i++) { mat = transform.GetChild(i).GetComponent<MeshRenderer>().material; CP.SetNewColor(mat.color); }
        isPaint = true;
    }

    private void StopPaint()
    {
        Destroy(go);
        isPaint = false;
    }
}
