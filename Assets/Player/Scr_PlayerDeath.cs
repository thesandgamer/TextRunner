using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scr_PlayerDeath : MonoBehaviour
{
    [Header("RayCast")]
    public float rayLength = 0.8f;
    private RaycastHit hitInfo;
    private bool dead;

    Scr_Player_Movement moveScript;

    [Header("HUD")]
    public GameObject deathPannel;
    public GameObject Ui;

    [Header("FX")]
    public GameObject deathFx;
         



    private void Awake()
    {
        moveScript = GetComponent<Scr_Player_Movement>();
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        if (Physics.Raycast(ray, out hitInfo, rayLength))
        {
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            Debug.Log("Dead");
            Death();
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * rayLength, Color.yellow);
        }
    }

    public void Death()
    {
        if(!dead)
        moveScript.enabled = false;
        //Play Animation of death
        if (!dead)
        {
            Instantiate(deathFx, transform.position, Quaternion.identity);
            FindObjectOfType<GameManager>().GetComponent<Scr_AudioPlayer>().PlayDeathSound();
            Invoke("ShowLooseMenu", 2);
            Ui.SetActive(false);
            dead = true;
            gameObject.SetActive(false);
        }
    }

    private void ShowLooseMenu()
    {
        Destroy(gameObject);
        deathPannel.SetActive(true);
    }
}

