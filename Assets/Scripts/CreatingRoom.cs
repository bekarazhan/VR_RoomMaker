using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreatingRoom : MonoBehaviour
{
    public InputField l;
    public InputField w;
    public InputField h;
    public static float length;
    public static float width;
    public static float hight;
    // Start is called before the first frame update
    public void CreateRoomButton()
    {
        
        length = float.Parse(l.text);
        width = float.Parse(w.text);
        hight = float.Parse(h.text);
        
        Measures.length = length;
        Measures.width = width;
        Measures.height = hight;
        SceneManager.LoadScene(1);
        
    }
    

   
 
}
