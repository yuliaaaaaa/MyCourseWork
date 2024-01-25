using System;
using UnityEngine;

public static class DBManager
{
    public static string username;
    public static string password;
    public static int score = (UIUpdaterScript.score);


    public static bool LoggedIn
    {
        get { return username != null; }
    }

    public static void LoggedOut()
    {
        username = null;
    }
}

