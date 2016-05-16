using UnityEngine;
using System.Collections;

public class Shark : MonoBehaviour 
{
	private Transform transformShark = null;
	public Transform target;
	public float velocidad;
	 

	void Awake()
	{
		transformShark = transform;
	}

	// Use this for initialization
	void Start ()
	{
		target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transformShark.position += target.transform.position * velocidad * Time.deltaTime;
		if (transformShark.position.x < -13)
		{
			transformShark.gameObject.SetActive (false);
		}
	}
}
