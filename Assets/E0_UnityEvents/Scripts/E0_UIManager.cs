// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class E0_UIManager : MonoBehaviour
{
    // A serialized UnityEvent that can be displayed in our Inspector.
    public UnityEvent customUnityEvent;

    // The function for enabling the Text after UnityEvent Invoke
    public void ActivateEventGameObject(string gameObjectName)
    {
        GameObject.Find(gameObjectName).GetComponent<Text>().enabled = true;
    }

    private void Start()
    {
        // We can also add Listeners from the code instead of the inspector.
        customUnityEvent.AddListener(DebugEvent);
    }

    private void Update()
    {
        // If MouseButton RightClick
        if (Input.GetMouseButtonDown(1))
        {
            // Invoke our UnityEvent and trigger all listening functions.
            // This is what happens in a ButtonClick.
            customUnityEvent.Invoke();
        }
    }

    public void DebugEvent()
    {
        Debug.Log("Event triggered.");
    }
}
