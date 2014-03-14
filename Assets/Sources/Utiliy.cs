using UnityEngine;
using System.Collections;

public static class Utiliy {
	
	public static GameObject CreateGameObject<T>(this GameObject gameObject, T type) where T : Object
	{
		if (type == null) Debug.LogError("Assigned Prefab missing. (Inspector)");
		// return (GameObject) gameObject.Instantiate(type) as GameObject; //, new Vector3(0, 0, 0), Quaternion.identity); 
		return null;
	}

	public static float Range(float min, float max, float excludeRangeMin, float excludeRangeMax)
	{
		return Random.Range(0,2) == 0 ? Random.Range(min, excludeRangeMin) : Random.Range(excludeRangeMax, max);
	}
}
