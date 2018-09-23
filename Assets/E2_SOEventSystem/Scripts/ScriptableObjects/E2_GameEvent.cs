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

// This is basically a event architecture with ScriptableObjects.
// All of our Listeners (see E2_GameEventListeners) will be notified if this Event is raised.
// Then they will respond over a UnityEvent.

[CreateAssetMenu(fileName = "New GameEvent", menuName = "Example2/Events/GameEvent", order = 1)]
public class E2_GameEvent : ScriptableObject
{
    // List of Listeners this Event will notify when triggered/raised.
    private List<E2_GameEventListener> listeners = new List<E2_GameEventListener>();

    // When our Event is raised, go through all our Listeners and call the OnEventRaised() function.
    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    // Add our Listener to our List if not already existing.
    public void RegisterListener(E2_GameEventListener listener)
    {
        if (!listeners.Contains(listener))
            listeners.Add(listener);
        else
            Debug.Log("Listener already in List");
    }

    // Remove our Listener from the list if List contains said Listener.
    public void UnregisterListener(E2_GameEventListener listener)
    {
        if (listeners.Contains(listener))
            listeners.Remove(listener);
        else
            Debug.Log("Nothing to remove");
    }
}
