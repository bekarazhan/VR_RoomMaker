using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnRoom1 : MonoBehaviour { 

    private float length, width, height;
GameObject floor;
GameObject ceil;
GameObject longwall1;
GameObject longwall2;
GameObject shortwall1;
GameObject shortwall2;
    GameObject longplin1;
    GameObject longplin2;
    GameObject shortplin1;
    GameObject shortplin2;
    
    //public GameObject _camera;

    public GameObject wallpref;
    //public GameObject playerMenu;
    public GameObject plintus;
    
   // public GameObject previewmat;
   


    // Start is called before the first frame update
    void Start()
    {
        //_camera.transform.position = new Vector3(0,Measures.height*10+50,0);



        length = Measures.length;
        width = Measures.width;
        height = Measures.height;
        Debug.Log(length + "  "+ width);
        //playerMenu.transform.position = transform.position+new Vector3 (0,1,0);

        longplin1 = Instantiate(plintus, transform.position + new Vector3(-1.9f,0, -10 * width / 2), transform.rotation, transform);
        longplin1.transform.localScale = new Vector3(length*11, 2, 1);

        longplin2 = Instantiate(plintus, transform.position + new Vector3(1.9f, 0, 10 * width / 2), transform.rotation * Quaternion.Euler(0f, 180f, 0f), transform);
        longplin2.transform.localScale = new Vector3(length * 11, 2, 1);

        shortplin1 = Instantiate(plintus, transform.position + new Vector3(10 * length / 2, 0, -0.9f), transform.rotation * Quaternion.Euler(0f, -90f, 0f), transform);
        shortplin1.transform.localScale = new Vector3(width* 11, 2, 1);

        shortplin2 = Instantiate(plintus, transform.position + new Vector3(-10 * length / 2, 0, 0.9f), transform.rotation * Quaternion.Euler(0f, 90f, 0f), transform);
        shortplin2.transform.localScale = new Vector3(width * 11, 2, 1);


        //wall = Instantiate(wallpref, transform.position +new Vector3(0, float.Parse(h.text), 0),  transform.rotation* Quaternion.Euler(0f, 0f, 90f));
        floor = Instantiate(wallpref, transform.position, transform.rotation,transform);
        floor.transform.localScale = new Vector3(length, 1, width);
        

        ceil = Instantiate(floor, transform.position + new Vector3(0, height * 10, 0), transform.rotation * Quaternion.Euler(0f, 0f, 180f), transform);
        longwall1 = Instantiate(wallpref, transform.position + new Vector3(0, 10 * height / 2, 10 * width / 2), transform.rotation * Quaternion.Euler(-90f, 0f, 0f), transform);
        longwall1.transform.localScale = new Vector3(length, 1, height);

        

        longwall2 = Instantiate(wallpref, transform.position + new Vector3(0, 10 * height / 2, -10 * width / 2), transform.rotation * Quaternion.Euler(90f, 0f, 0f), transform);
        longwall2.transform.localScale = new Vector3(length, 1, height);

        shortwall1 = Instantiate(wallpref, transform.position + new Vector3(10 * length / 2, 10 * height / 2, 0), transform.rotation * Quaternion.Euler(-90f, 0f, 90f), transform);
        shortwall1.transform.localScale = new Vector3(width, 1, height);

        shortwall2 = Instantiate(wallpref, transform.position + new Vector3(-10 * length / 2, 10 * height / 2, 0), transform.rotation * Quaternion.Euler(90f, 0f, -90f), transform);
        shortwall2.transform.localScale = new Vector3(width, 1, height);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
