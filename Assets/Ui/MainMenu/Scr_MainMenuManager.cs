using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_MainMenuManager : MonoBehaviour
{

    public void GoToLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void AffichePannel(GameObject pannel)
    {
        pannel.SetActive(true);
    }

    public void CachePannel(GameObject pannel)
    {
        pannel.SetActive(false);
    }

    public void QuitGame()
    {
        QuitGame();
    }
}
