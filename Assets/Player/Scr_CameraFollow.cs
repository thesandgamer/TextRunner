using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_CameraFollow : MonoBehaviour
{
    public Transform player;
    private Vector3 target = Vector3.zero;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            target = new Vector3(0, player.position.y + offset.y, player.position.z + offset.z);
            transform.position = Vector3.Lerp(transform.position, target, 1f);
        }
        
    }
}
