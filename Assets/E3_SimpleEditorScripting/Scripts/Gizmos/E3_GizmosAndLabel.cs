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

public class E3_GizmosAndLabel : MonoBehaviour
{
    public GameObject player;
    public GameObject goal;

    // GUIStyle alllows us to define a custom style (with custom color, style, etc.)
    private GUIStyle greenStyle = new GUIStyle();
     
    // Gizmos and Handles are drawn in OnDrawGizmos()
    private void OnDrawGizmos()
    {
        greenStyle.normal.textColor = Color.green;

        // The Unity Documentation shows what kind of Gizoms we can draw (e.g. Lines, Cubes, Icons)
        // Here the WireCube and Cube are used. DrawWireCube draws the Edges and DrawCube a cube inside of it.
        Gizmos.color = new Color(0f, 1f, 0f);
        Gizmos.DrawWireCube(goal.GetComponent<BoxCollider>().transform.position, goal.GetComponent<BoxCollider>().size);

        Gizmos.color = new Color(0f, 1f, 0f, 0.5f);
        Gizmos.DrawCube(goal.GetComponent<BoxCollider>().transform.position, goal.GetComponent<BoxCollider>().size);

        Gizmos.color = new Color(1f, 1f, 1f, 0.8f);
        Gizmos.DrawLine(goal.transform.position, player.transform.position);

        // Handles are a way of drawing cutsom 3D GUI Elements (more complex than Gizoms) into our Unity Editor (e.g. Text).
        Handles.Label(player.transform.position + Vector3.up, "Player 1", greenStyle);
    }

    //Gizmos and Handles that have been selected in the Editor are drawn in OnDrawGizmosSelected()
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1f, 0f, 0f);
        Gizmos.DrawWireCube(goal.GetComponent<BoxCollider>().transform.position, goal.GetComponent<BoxCollider>().size);

        Gizmos.color = new Color(1f, 0f, 0f, 0.5f);
        Gizmos.DrawCube(goal.GetComponent<BoxCollider>().transform.position, goal.GetComponent<BoxCollider>().size);
    }

}