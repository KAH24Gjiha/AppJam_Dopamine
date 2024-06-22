using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public PlayerData playerData;
   
    private void Awake()
    {
        playerData = DataManager.Instance.playerDB;
    }
    void Start()
    {
        
    }
}
