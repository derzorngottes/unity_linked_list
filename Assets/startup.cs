using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startup : MonoBehaviour {

	public Terrain terrainMap;

	// Use this for initialization
	void Start () {
		CreateTerrain ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CreateTerrain() {
		GameObject TerrainObj = new GameObject("TerrainObj");

		TerrainData _TerrainData = new TerrainData();

		// terrain is 10 x 10, try changing to 50 x 50 for a much larger city
		_TerrainData.size = new Vector3(10, 600, 10);
		_TerrainData.heightmapResolution = 512;
		_TerrainData.baseMapResolution = 1024;
		_TerrainData.SetDetailResolution(1024, 16);

		TerrainCollider _TerrainCollider = TerrainObj.AddComponent<TerrainCollider>();
		terrainMap = TerrainObj.AddComponent<Terrain>();

		_TerrainCollider.terrainData = _TerrainData;
		terrainMap.terrainData = _TerrainData;
	}
}
