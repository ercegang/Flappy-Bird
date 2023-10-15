using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyButton : MonoBehaviour
{
   
    public string nextSceneName;
    void OnMouseDown()
    {
        transform.position += Vector3.down * 0.10f;
        
    }

    void OnMouseUp()
    {
        transform.position += Vector3.up * 0.10f;
        if(nextSceneName != "")
        {
            SceneManager.LoadScene(nextSceneName);
        }
            
    }
}
