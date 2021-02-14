using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Player_EffectGiver : MonoBehaviour
{
    [Header("RayCast")]
    [Range(0,100)]
    public float rayLength = 50;

    public Scr_TextDetection textTyping;

    private string effet;

    private RaycastHit hitInfo;

    private LineRenderer lr;

    private void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        
        if (Physics.Raycast (ray,out hitInfo, rayLength))
        {
            Debug.DrawLine(ray.origin, hitInfo.point, Color.red);
            //lr.SetPosition(0, hitInfo.point);
            
        }
        else
        {
            Debug.DrawLine(ray.origin, ray.origin + ray.direction * rayLength, Color.green);
        }
    }

    public void Effect(string effect)
    {
        effet = effect;
        if (hitInfo.collider.gameObject.CompareTag("Platforme"))
        {
            hitInfo.collider.gameObject.GetComponent<Scr_TextEffect>().ActiveEffect(effet);
        }
    }


}
