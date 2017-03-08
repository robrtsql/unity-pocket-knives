using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEditor.Animations;

[Tiled2Unity.CustomTiledImporter]
public class ColliderTiledImporter : Tiled2Unity.ICustomTiledImporter
{
	public void HandleCustomProperties(GameObject gameObject,
		IDictionary<string, string> customProperties)
	{
		//We have nothing to do with the properties...
	}
 
	public void CustomizePrefab(GameObject prefab)
	{
		foreach (Transform child in prefab.transform.FindChild("Object Layer 1"))
		{
			child.gameObject.AddComponent<WorldEntity>().type = EntityType.Obstacle;
		}
		foreach (Transform child in prefab.transform.FindChild("Object Layer 2"))
		{
			child.gameObject.AddComponent<WorldEntity>().type = EntityType.Trigger;
		}
	}
}