using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scr_LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime = 1f;


    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadSpecificLevel(int nb)
    {
        StartCoroutine(LoadLevel(nb));
    }


    public void LaunchTransitionInterne()
    {
        StartCoroutine(LaunchTransition());
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }

    IEnumerator LaunchTransition()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);
    }

}
