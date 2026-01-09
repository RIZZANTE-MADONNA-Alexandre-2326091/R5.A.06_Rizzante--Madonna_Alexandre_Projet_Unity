using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killable : MonoBehaviour
{
    private bool IsKilled = false;

    public bool GetIsKilled()
    {
        return IsKilled;
    }

    public void SetKilled(bool killStatus)
    {
        IsKilled = killStatus;
    }

    public void Kill()
    {
        IsKilled = true;
        GameplayManager.DisableManagable();
        GameplayUIManager.ShowKillScreen();
        Debug.Log(name = " est mort.");
    }
}
