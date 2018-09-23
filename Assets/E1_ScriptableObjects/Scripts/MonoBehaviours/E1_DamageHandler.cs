// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Decrease the referenced PlayerHealth by 1 when clicking the left MouseButton.
public class E1_DamageHandler : MonoBehaviour
{
    public E1_PlayerData playerData;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            playerData.playerHealth--;
    }
}
