/*using UnityEngine;
using System.Collections;

public class sphere1 : MonoBehaviour {
	
	Transform target ;  //the enemy's target
    float moveSpeed = 3; //move speed
    //float rotationSpeed = 3; //speed of turning
 
    Transform myTransform ; //current transform data of this enemy
 
    void Awake()
    {
   		 myTransform = transform; //cache transform data for easy access/preformance
    }
 
    void Start()
    {
    	target = GameObject.FindWithTag("Player").transform; //target the player
	}
 	void Update () 
	{
    	//rotate to look at the player
    //	myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
    //	Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
 
 		//move towards the player
   		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
	}
}
*/
using UnityEngine;
using System.Collections;
 
public class sphere8: MonoBehaviour
{
    Vector3 chaseVel, chaseDir, chasPos;
 	Transform playerPos ;  //the enemy's target
    void Start() 
	{ 
		chaseVel = new Vector3(1f, 0f, 0f); 
		playerPos = GameObject.FindWithTag("Player").transform; //target the player
	}
 
    void Update()
    {
        chaseDir = playerPos.position - transform.position;
        Vector3 tmpNormalizedDir = Vector3.Normalize(chaseDir);
        chaseDir = new Vector3(tmpNormalizedDir.x * chaseVel.x, tmpNormalizedDir.y * chaseVel.y, tmpNormalizedDir.z * chaseVel.z);
        chaseDir *= Time.deltaTime;
        this.transform.position += chaseDir;
		gameObject.renderer.material.color = Color.blue;
    }
}
