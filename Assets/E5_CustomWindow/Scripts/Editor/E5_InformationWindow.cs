// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

// Don't forget that we derive from EditorWindow
public class E5_InformationWindow : EditorWindow
{
    string stringOne = "This is a Unity Workshop about Editor Scripting. Yey!";
    string stringTwo = "Did you like it?";
    bool likeBool = false;
    bool dislikeBool = false;
    int rating = 5;

    // The Editor Menu Position our Window should be called from
    [MenuItem("Window/InformationWindow")]
    static void InitializeWindow()
    {
        // E5_InformationWindow is the type of Window we want to open.
        // Unity checks if one is already open. If it is, it won't open a second one.
        GetWindow<E5_InformationWindow>("Information");
    }

    private void OnGUI()
    {
        // Here our Window is drawn.
        // Like OnInspectorGUI() but for Windows.
        // Works mostly like Custom Inspectors.

        GUILayout.Label(stringOne, EditorStyles.boldLabel);
        GUILayout.Space(30);
        GUILayout.Label(stringTwo);

        // We can give our HorizontalGroup a custom skin.
        GUILayout.BeginHorizontal(GUI.skin.box);
        likeBool = EditorGUILayout.Toggle("Yes", likeBool);
        dislikeBool = EditorGUILayout.Toggle("No", dislikeBool);
        GUILayout.EndHorizontal();

        GUILayout.Space(20);
        rating = EditorGUILayout.IntSlider("From 1 to 10", rating, 1, 10);

        if (GUILayout.Button("Send rating"))
        {
            Debug.Log("Information send");
        }
    }
}