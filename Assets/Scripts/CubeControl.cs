using UnityEngine;
using System.Collections;

public class CubeControl : MonoBehaviour {
	public float rotateSpeed=10f;

	void Update () {
		float deltaY= Time.deltaTime * Input.GetAxis("Horizontal") * rotateSpeed;
		float deltaX= Time.deltaTime * Input.GetAxis("Vertical") * rotateSpeed;
		transform.Rotate(deltaX,deltaY,0);
	}
}
