using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject weaponRef; // Reference to the GameObject containing the Weapon script and parent to weapon fields
    public GameObject trinketRef; // Reference to the GameObject containing the Trinket script and parent to trinket fields

    public Vector2 fieldSize = new Vector2(100, 100); // Default field size
    public Vector2 spriteSize = new Vector2(80, 80); // Default sprite size
    public Vector2 weaponOffset = new Vector2(110, 0); // Offset for weapon fields
    public Vector2 trinketOffset = new Vector2(0, -110); // Offset for trinket fields

    public Sprite fieldSprite; // The background sprite for each field

    private void Start()
    {
        InitializeFields();
    }

    private void InitializeFields()
    {
        Vector2 currentWeaponPosition = Vector2.zero; // Start position for weapon fields
        Vector2 currentTrinketPosition = Vector2.zero; // Start position for trinket fields

        Weapon weaponComponent = weaponRef.GetComponent<Weapon>();
        if (weaponComponent != null)
        {
            foreach (var weaponData in weaponComponent.allWeaponData)
            {
                CreateInventoryItem(null, true, weaponRef.transform, ref currentWeaponPosition, weaponOffset);
            }
        }

        Trinket trinketComponent = trinketRef.GetComponent<Trinket>();
        if (trinketComponent != null)
        {
            foreach (var trinketData in trinketComponent.allTrinketData)
            {
                CreateInventoryItem(null, false, trinketRef.transform, ref currentTrinketPosition, trinketOffset);
            }
        }
    }

    public void AddItem(Sprite itemSprite, bool isWeapon, int index)
    {
        // This function will now need to find the correct field based on index and update its sprite
        // This part of the script will require adjustments to access and modify existing fields
    }

    void CreateInventoryItem(Sprite itemSprite, bool isWeapon, Transform parentObject, ref Vector2 currentPosition, Vector2 offset)
    {
        GameObject fieldGO = new GameObject(isWeapon ? "WeaponField" : "TrinketField", typeof(Image));
        fieldGO.transform.SetParent(parentObject, false);
        fieldGO.GetComponent<Image>().sprite = fieldSprite;

        RectTransform fieldRect = fieldGO.GetComponent<RectTransform>();
        fieldRect.sizeDelta = fieldSize;
        fieldRect.anchoredPosition = currentPosition;

        currentPosition += offset; // Update current position with offset for the next field

        // The following part is modified to initially not create an item image inside the field
        // Item images will be added or updated later through the AddItem method
    }
}
