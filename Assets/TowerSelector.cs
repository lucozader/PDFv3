using UnityEngine;
using System.Collections;

public class TowerSelector : MonoBehaviour {
	
	public GameObject[] towerIcons;
	public GameObject[] towers;
	public int[] towerCosts;
	
	public float towerIconRotateRate = 1.0f;
	
	private int selectedTower = 0;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		towerIcons[selectedTower].transform.Rotate(Vector3.up, towerIconRotateRate * Time.deltaTime);
	}
	
	public GameObject GetSelectedTower()
	{
		return towers[selectedTower];
	}
	
	public int GetSelectedTowerCost()
	{
		return towerCosts[selectedTower];
	}
	
	void SetSelectedTower(GameObject inputTower)
	{
		int index = 0;
		foreach(GameObject towerIcon in towerIcons)
		{
			Debug.Log(inputTower);
			if(inputTower == towerIcon)
			{
				selectedTower = index;
			}
			index++;
		}
	}
}
