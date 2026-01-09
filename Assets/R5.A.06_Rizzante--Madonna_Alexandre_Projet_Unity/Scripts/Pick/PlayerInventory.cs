using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInventory : Pickable
{
    [SerializeField] uint NumberOfCoins = 0;

    public void AddCoin()
    {
        ++NumberOfCoins;
    }
}
