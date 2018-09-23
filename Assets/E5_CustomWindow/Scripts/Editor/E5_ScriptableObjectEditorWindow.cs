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
public class E5_ScriptableObjectEditorWindow : EditorWindow
{

    E4_PlayerData myScriptableObject;
    bool disabledControls = true;

    // The Editor Menu Position our Window should be called from
    [MenuItem("Window/Scriptable Object Editor")]
    static void InitializeWindow()
    {
        // E5_InformationWindow is the type of Window we want to open.
        // Unity checks if one is already open. If it is, it won't open a second one.
        GetWindow<E5_ScriptableObjectEditorWindow>("Scriptable Object Editor");
    }

    private void OnGUI()
    {
        DrawSOBox();
        // If our ObjectField is not empty, draw the rest.
        if (myScriptableObject != null)
            DrawPlayerData();
    }

    void DrawSOBox()
    {
        // An ObjectField allows us to reference a GameObject (or ScriptableObject). We want a SO of type E4_PlayerData.
        myScriptableObject = EditorGUILayout.ObjectField(myScriptableObject, typeof(E4_PlayerData), true) as E4_PlayerData;
    }

    void DrawPlayerData()
    {
        if (myScriptableObject != null)
        {
            disabledControls = false;
        }
        else
        {
            disabledControls = true;
        }

        // Disabled Groups allow us to have disabled elements.
        EditorGUI.BeginDisabledGroup(disabledControls);

        // We can give our HorizontalGroup a custom skin.
        GUILayout.BeginHorizontal(GUI.skin.box);
        GUILayout.Label("Name:  ");
        // Undo.RecordObject gives us the possibilty to undo our changes with Strg+Z or Edit >> Undo
        Undo.RecordObject(myScriptableObject, "Changed SO");
        myScriptableObject.playerName = EditorGUILayout.TextField(myScriptableObject.playerName);
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal(GUI.skin.box);
        GUILayout.Label("Health: ");
        Undo.RecordObject(myScriptableObject, "Changed SO");
        myScriptableObject.playerHealth = EditorGUILayout.IntField(myScriptableObject.playerHealth);
        GUILayout.EndHorizontal();

        EditorGUI.EndDisabledGroup();
    }
}
