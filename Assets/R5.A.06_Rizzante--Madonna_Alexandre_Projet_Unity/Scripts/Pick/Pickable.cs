using UnityEngine;

public class Pickable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerToPick = other.GetComponent<PlayerInventory>();
        if (playerToPick != null)
        {
            playerToPick.AddCoin();
        }
    }
}
