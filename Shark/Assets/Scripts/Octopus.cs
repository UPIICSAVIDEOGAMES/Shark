using UnityEngine;
using System.Collections;

public class Octopus : MonoBehaviour
{
    public float velocidad;
	public bool activeShark = false;
    public Transform transformOctopus = null;
	public GameObject sharkGO;

    void Start()
    {
        transformOctopus = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
		if (activeShark == true)
		{
			sharkGO.SetActive (true);
			sharkGO.transform.position = new Vector2 (10, 0);
		}
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
			transformOctopus.position = transformOctopus.position + new Vector3 (0f, 1f, 0f) * Time.deltaTime * velocidad;
        }
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			transformOctopus.Translate (Vector2.down * velocidad * Time.deltaTime);
		}
	}
}