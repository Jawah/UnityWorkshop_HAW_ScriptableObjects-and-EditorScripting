// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class E2_PlayerMovement : MonoBehaviour
{
    public float speed;
    public float size = 1f;

    private Rigidbody rb;

    // We want to Invoke() our Event with another UnityEvent.
    public UnityEvent winEvent;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Goal")
        {
            // When we reach a GameObject named Goal we Invoke() our custom ScriptableObject Event 
            // and every Listener Invokes() their respective UnityEvent.
            winEvent.Invoke();
            Time.timeScale = 0f;
        }
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }
}