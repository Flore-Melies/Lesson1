using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMovingCubeBehaviour : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Renderer objectToChange;
    
    private bool shouldMove = false;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(shouldMove)
            GetComponent<Rigidbody>().MovePosition(transform.position + Vector3.right * (speed * Time.fixedDeltaTime));
        if (Input.GetKeyDown(KeyCode.Space) && !shouldMove)
            shouldMove = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        objectToChange.material.color = Color.cyan;
    }

    private void OnCollisionEnter(Collision other)
    {
        objectToChange.material.color = Color.red;
    }
}
