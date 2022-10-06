using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Assets/Item")]

public class Items : ScriptableObject
{
    public string itemID;
    public string itemName;
    [TextArea]
    public string itemDescription;
    public int itemCost;
}
