// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
//
// This part is highly influenced by Ryan Hipple's talk at Unity Austin 2017.
// GitHub Repository: https://github.com/roboryantron/Unite2017
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class E3_GameEventListener : MonoBehaviour
{
    // Referencing the GameEvent.
    public E3_GameEvent Event;
    // If raised, we want to invoke this UnityEvent called Response.
    public UnityEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
