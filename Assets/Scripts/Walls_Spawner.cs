using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls_Spawner : MonoBehaviour
{
    public GameObject corner;
    private LineRenderer lr;
    private GameObject[] array;
    private int i=0;
    private Vector3 updatepos;
    public GameObject wall_prefab;
    // Start is called before the first frame update
    void Start()
    {

        lr = GetComponent<LineRenderer>();
        lr.positionCount = 0;
        array = new GameObject[50];
    }

    // Update is called once per frame
    void Update()
    {
        if (lr.positionCount>=1) {
            for (int k = 0; k < lr.positionCount; k++) { lr.SetPosition(k, array[k].transform.position); }
            //lastpos = array[lr.positionCount].transform.position+ new Vector3(10, 0, 0);
        }

        
        
    }

    public void Create() 
    {
       
        array[i] = Instantiate(corner);

        lr.positionCount++;
        SetLine(i, transform.position);
       
        i++;
        

    }

    private void SetLine(int k,Vector3 lp) 
    {
        
        lr.SetPosition(k,lp);
    }

    public void Complete() 
    {
        lr.loop = true;

    }

    public void SpawnButton() {

        SpawnBlocks(lr.GetPosition(0), lr.GetPosition(1));
    }


    void SpawnBlocks(Vector3 startPos, Vector3 endPos)
    {
        
        GameObject ground = Instantiate(wall_prefab);
        Vector3 centerPos = new Vector3(startPos.x + endPos.x, startPos.y + endPos.y) / 2;

        float scaleX = Mathf.Abs(startPos.x - endPos.x);
        float scaleY = Mathf.Abs(startPos.y - endPos.y);

        centerPos.x -= 0.5f;
        centerPos.y += 0.5f;
        ground.transform.position = centerPos;
        ground.transform.localScale = new Vector3(scaleX, 1, 1);
    }




}
