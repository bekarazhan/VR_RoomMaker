using UnityEngine;
using UnityEngine.UI;

public class ItemsManager : MonoBehaviour
{
    Dropdown dr;
    GameObject currentGO;
    public GameObject _selectingPlane;
    public GameObject _room;
    void Start()
    {
        dr = transform.GetComponent<Dropdown>();
        SetObject();
        foreach (var item in DBobjects.items)
        {
            dr.options.Add(new Dropdown.OptionData() { text = item.name });
        }
    }

    public void SetObject() 
    {
        currentGO = DBobjects.items[dr.value];
    }

    public void SpawnObject() 
    {
        if (currentGO != null)
        {
            var ob = Instantiate(currentGO, new Vector3(0, 0.3f, 0),
                new Quaternion(0, 0, 0, 0), _room.transform);
            Instantiate(_selectingPlane, ob.transform.position, 
                new Quaternion(0, 0, 0, 0),ob.transform);

        }
    }
}
