using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Player")]
    public Scr_Player_Movement player;
    public GameObject Ui;

    [Header("Timer")]
    public Text counter;

    public float timer = 3.0f;

    private void Start()
    {
        Ui.SetActive(false);
        player.enabled = false;
        Invoke("StartCoroutine", 1);

    }

    void StartCoroutine()
    {
        StartCoroutine(StartCounter());
    }

    IEnumerator StartCounter()
    {
        Debug.Log("Coroutine start");
        while (timer > 1)
        {
            timer -= Time.deltaTime;
            counter.text = (timer).ToString("0");
            yield return null;
        }
        counter.text = "GO";
        StopCoroutine("StartCounter");
        StartGame();
        Invoke("HideCounter", 1);
        

    }

    void StartGame()
    {
        player.enabled = true;
        Ui.SetActive(true);
    }

    void HideCounter()
    {
        counter.text = null;
    }


    public void RestartLevel()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        QuitGame();
    }
}
