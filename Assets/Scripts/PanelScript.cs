
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelScript : MonoBehaviour
{
  
    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButtonDown(0))
        {
            
            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
       
        SceneManager.LoadScene("Levelone");
    }
    }

