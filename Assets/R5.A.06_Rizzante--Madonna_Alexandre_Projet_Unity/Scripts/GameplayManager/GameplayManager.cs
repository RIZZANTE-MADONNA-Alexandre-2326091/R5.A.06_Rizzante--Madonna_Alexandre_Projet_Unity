using System;
using System.Collections;
using UnityEditor;
using UnityEngine;
using BUT;

public class GameplayManager : MonoBehaviour
{
    private static bool IsManagable;

    private void Start()
    {
        IsManagable = true;
    }

    public static void EnableManagable()
    {
        IsManagable = true;
    }

    public static void DisableManagable()
    {
        IsManagable = false;
    }
}
