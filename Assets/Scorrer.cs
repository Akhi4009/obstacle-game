using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorrer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)

    {
        hits++;
        Debug.Log("You 've hit wall this many times: " + hits);
    }
}
