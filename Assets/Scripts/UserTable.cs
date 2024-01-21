using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserTable : MonoBehaviour
{

    public TMP_Text playerDisplay;

    private void Start()
    {

        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Player: " + DBManager.username;

        }
    }
}
