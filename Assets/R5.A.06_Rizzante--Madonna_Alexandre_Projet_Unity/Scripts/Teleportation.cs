using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 m_StartPosition;
    [SerializeField] Vector3 m_EndPosition;

    public void Teleport()
    {
        if (player.position == m_StartPosition)
        {
            player.position = m_EndPosition;
        }
    }
}
