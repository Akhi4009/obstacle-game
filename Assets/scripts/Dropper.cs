using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drpper : MonoBehaviour
{
    MeshRenderer renderere;
    Rigidbody rigidBody;
    [SerializeField] float timeToWait = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Akhilesh yadav");
        renderere = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renderere.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            renderere.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
