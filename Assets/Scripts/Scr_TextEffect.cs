using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_TextEffect : MonoBehaviour
{
    public Scr_TextDetection text;

    public float distanceToMove;

    IEnumerator currentMoveCoroutine;

    void Awake()
    {
        text = GetComponent<Scr_TextDetection>();
    }

    public void ActiveEffect(string effet)
    {
        switch (effet)
        {
            case "left":
                currentMoveCoroutine = Move(new Vector3(transform.position.x  + -distanceToMove, transform.position.y, transform.position.z), 8);
                StartCoroutine(currentMoveCoroutine);
                break;

            case "right":
                currentMoveCoroutine = Move(new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z), 8);
                StartCoroutine(currentMoveCoroutine);
                break;

            default:
                Debug.Log("Nothing");
                break;

        }
    }

    IEnumerator Move(Vector3 destination, float speed)
    {
        Debug.Log("Couroutine Start");
        while(transform.position != destination)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
            yield return null;
        } 
    }

}
