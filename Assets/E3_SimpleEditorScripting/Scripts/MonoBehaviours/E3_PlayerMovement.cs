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

[RequireComponent(typeof(Rigidbody))]
public class E3_PlayerMovement : MonoBehaviour
{
    [Header("Player Information")]
    public float speed;

    [Range(0.1f, 2f)] // make a slider for your variables with min, max values
    public float size = 1f;

    [SerializeField] // to show private variables in Inspector
    private Rigidbody rb;

    [TextArea]
    public string exampleString;

    [Space(25)]
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