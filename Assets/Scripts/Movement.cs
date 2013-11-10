using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	float speed = 5;
	float x;
	float z;
	
	void FixedUpdate()
	{
		 x = Input.GetAxis("Horizontal") * speed * Time.deltaTime; 
     	 z = Input.GetAxis("Vertical") * speed * Time.deltaTime; 
     	 transform.Translate(x, z, 0); 
		gameObject.renderer.material.color = Color.red;
		
  }
}
	

