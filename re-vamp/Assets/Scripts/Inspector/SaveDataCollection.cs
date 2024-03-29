using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(DataCollection))]
class SaveDataCollection : Editor
{
    public DataCollection data;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("Test")) 
        {
            data.AddWeaponData();

            data.AddTrinketData();

            Debug.Log("Weapons and Trinket Saved");
        }
    }
}
