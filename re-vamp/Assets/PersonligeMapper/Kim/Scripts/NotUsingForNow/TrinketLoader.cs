using UnityEngine;

public class TrinketLoader : MonoBehaviour
{
    public TextAsset jsonFile;

    void Start()
    {
        LoadTrinkets();
    }

    void LoadTrinkets()
    {
        if (jsonFile != null)
        {
            TrinketCollection trinketCollection = JsonUtility.FromJson<TrinketCollection>(jsonFile.text);

            foreach (Trinkets trinkets in trinketCollection.trinkets)
            {
                Debug.Log($"Loaded Trinket: {trinkets.name}, Level: {trinkets.attributes.level}");

                // Here you can instantiate GameObjects or assign values to them based on the trinket data
                // For example, creating a new GameObject for each trinket or finding existing ones and setting their properties
            }
        }
        else
        {
            Debug.LogError("JSON file not assigned.");
        }
    }
}