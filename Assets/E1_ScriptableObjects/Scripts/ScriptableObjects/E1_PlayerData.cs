// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CreateAssetMenu for the possibility to create Scriptable Objects over the Editor (like a Cube for Example)
[CreateAssetMenu(fileName = "E1_PlayerData", menuName = "Example1/Player/Data", order = 1)]
public class E1_PlayerData : E1_ResettableScriptableObject
{
    // Most of the time using ScriptableObjects as data container.
    public string playerName = "New Player";
    public enum PlayerClasses { Mage, Warrior, Rogue, Healer }
    public PlayerClasses playerClass;
    public string playerDescription = "Description";
    public int playerHealth = 100;

    // We can also define functions in our SO's if needed.
    public override void Reset()
    {
        playerHealth = 100;
    }
}
