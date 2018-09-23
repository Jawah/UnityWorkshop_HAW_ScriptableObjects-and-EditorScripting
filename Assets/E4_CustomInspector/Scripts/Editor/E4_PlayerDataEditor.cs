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

// We have to define on what kind of script our EditorScript should work on.
// Don't forget that every EditorScript MUST be in the Editor Folder 
// or a Subfolder of the Editor Folder and we derive from Editor.
[CustomEditor(typeof(E4_PlayerData))]
public class E4_PlayerDataEditor : Editor
{
    // In OnInspectorGUI() our Inspector is drawn.
    // So to change or write in the Inspector, do it always in this function.
    public override void OnInspectorGUI()
    {
        // Because we overrride the function, everything that is drawn by Unity disappears.
        // If we want to use what Unity draws as a base, call base.OnInspectorGUI()
        base.OnInspectorGUI();

        // GUI, GUILayout and EditorGUILayout are the classes which have all the functionalities
        // we need. Most of the functions are self-explanotory like Space(). Check the Unity docs.
        GUILayout.Space(15);

        // When we want to access data from our "target"-script, we can do that with the target variable.
        // Don't forget to cast the script-type because target is imported simply as object.
        E4_PlayerData playerData = (E4_PlayerData)target;

        // Start horizontal Box.
        EditorGUILayout.BeginHorizontal();

        // Draw and Check Buttons for Clicks.
        if (GUILayout.Button("Print PlayerInfo to console"))
        {
            Debug.Log(playerData.playerName + " is a " + playerData.playerClass + " with " + playerData.playerHealth + " health. Nice!");
        }

        if (GUILayout.Button("Print PlayerInfo to console"))
        {
            Debug.Log(playerData.playerName + " is a " + playerData.playerClass + " with " + playerData.playerHealth + " health. Nice!");
        }

        //End horizontal Box.
        EditorGUILayout.EndHorizontal();
    }
}
