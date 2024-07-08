
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void Load(int index) { 
    
        SceneManager.LoadScene(index);
    }


    public void Quit()
    {

        Application.Quit();
    }

}
