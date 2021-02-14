using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_KillZone : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Scr_PlayerDeath>().Death();

        }
    }

}
