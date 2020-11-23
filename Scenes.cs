using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    // pindah scene ke menu
    public void MenuScene()
    {
        SceneManager.LoadScene("Menu");
    }

    // pindah scene ke loading
    public void LoadingScene()
    {
        SceneManager.LoadScene("Loading");
    }
    // keluar dari gamr 
    public void KeluarScene()
    {
        Application.Quit();
    }
}
