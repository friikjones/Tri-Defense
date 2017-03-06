using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	public float speed;
	public Rigidbody rb;
	public int controllerType;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();
		speed = 20;
		controllerType = 1; //Keyboard
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (controllerType == 1)
		Char_Move(KeyCode.W,KeyCode.S,KeyCode.A,KeyCode.D);
	}
	
	void Char_Move (KeyCode Up, KeyCode Down, KeyCode Left, KeyCode Right)
	{
		
		if(Input.GetKey(Up))
		{
			transform.Translate(new Vector3(0,0,1) * speed * Time.deltaTime, Space.World);
		}
		if(Input.GetKey(Down))
		{
			transform.Translate(new Vector3(0,0,-1) * speed * Time.deltaTime, Space.World);
		}
		if(Input.GetKey(Left))
		{
			transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime, Space.World);
		}
		if(Input.GetKey(Right))
		{
			transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime, Space.World);
		}
		
		transform.LookAt(new Vector3(0,0,0));		//Vira o personagem para a Arvore
		transform.Rotate(new Vector3(0,180,0));		//Vira de costas
		
		
	}
}
