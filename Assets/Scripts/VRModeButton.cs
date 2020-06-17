using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VRModeButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _room;
    public void StartVR() 
    {
        StartCoroutine(ChangeScene());
        
    }

    IEnumerator ChangeScene() 
    {
        SceneManager.LoadScene(2, LoadSceneMode.Additive);
        Scene sceneToLoad = SceneManager.GetSceneByName("CreatedRoom");
        
        SceneManager.MoveGameObjectToScene(_room, sceneToLoad);
        yield return null;
        SceneManager.UnloadSceneAsync(1);
    }
   


}
