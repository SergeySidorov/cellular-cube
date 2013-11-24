using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {
	public Transform board;
	public GameObject prefabCell;
	public int numOfCells=100;

	void Start () {
		for(int i=0;i<numOfCells;i++) {
			Vector3 position=new Vector3(Random.Range(-50,50),Random.Range(-50,50),-50);
			GameObject cell=GameObject.Instantiate(prefabCell,position,Quaternion.identity) as GameObject;
			cell.transform.parent=board;
		}
	}
	
}
