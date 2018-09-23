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

public class E1_PlayerHandler : MonoBehaviour
{
    // We can reference SO's like every other Component or GameObject...
    public E1_PlayerData playerData;
    public Text playerName;
    public Text playerClass;
    public Text playerDescription;
    public Text playerHealth;

    private void Start()
    {
        //... and use them like every other class when wanting to reference the data.
        playerName.text = playerData.playerName;
        playerClass.text = playerData.playerClass.ToString();
        playerDescription.text = playerData.playerDescription;
        playerHealth.text = playerData.playerHealth.ToString();
    }

    private void Update()
    {
        playerHealth.text = playerData.playerHealth.ToString();
    }
}
