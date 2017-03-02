using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public float speed;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();
		speed = 20;
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime);
		}

	}
}
