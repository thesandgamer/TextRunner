using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_End : MonoBehaviour
{
    public GameObject WinPannel;
    
    private void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("Player"))
        {
            WinPannel.SetActive(true);
            FindObjectOfType<GameManager>().GetComponent<Scr_AudioPlayer>().PlayWinSound();
            other.gameObject.SetActive(false);
        }
    }
}
