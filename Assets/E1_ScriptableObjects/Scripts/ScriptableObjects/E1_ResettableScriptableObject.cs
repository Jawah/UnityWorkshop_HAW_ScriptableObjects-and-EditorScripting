// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We can simply use abstracts (or interfaces) with our ScriptableObjects like with every other class.
// In this case making the Reset() function necessary for all Classes (SO's) deriving from ResettableScriptableObject.
public abstract class E1_ResettableScriptableObject : ScriptableObject
{
    public abstract void Reset();
}