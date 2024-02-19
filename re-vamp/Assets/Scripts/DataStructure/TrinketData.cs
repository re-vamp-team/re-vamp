using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/TrinketData")]
public class TrinketData : ScriptableObject
{
    public string trinketName;
    public string description;
    public int level;
    public int maxHealthIncrease;
    public int damageIncrease;
    public int armorIncrease;
    public bool itemShopSlotIncrease;
    public bool canLevelUp;
    public float projectileSpeedIncrease;
    public float movementSpeedIncrease;
    public float viewDistanceIncrease;
    public float levelMultiplier;
    public GameObject trinketPrefab;
}
