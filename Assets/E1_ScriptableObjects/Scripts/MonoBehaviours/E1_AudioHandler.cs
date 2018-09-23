// ----------------------------------------------------------------------------
// Unity Workshop - HAW Hamburg
// 
// Author: Nenad Slavujevic
// Date:   10/09/18
// ----------------------------------------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Play a sound once when the referenced PlayerHealth is 50 or less.
public class E1_AudioHandler : MonoBehaviour
{
    public E1_PlayerData playerData;
    private bool soundPlayed = false;

    private void Update()
    {
        if (playerData.playerHealth <= 50 && !soundPlayed)
        {
            GetComponent<AudioSource>().Play();
            soundPlayed = true;
        }
    }
}
