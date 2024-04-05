using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorrer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)

    {
        if (!other.gameObject.CompareTag("hit"))
        {
            hits++;
        }
        Debug.Log("You 've hit wall this many times: " + hits);
    }
}
