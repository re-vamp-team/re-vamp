using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/TrinketData")]
public class TrinketData : ScriptableObject, IZShopItem
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
    public float FOV;
    public GameObject trinketPrefab;

    public Sprite GetSprite() => trinketPrefab.GetComponent<SpriteRenderer>().sprite;
}
