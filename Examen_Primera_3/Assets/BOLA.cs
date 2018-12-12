using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOLA : MonoBehaviour {

    float velocidad = -0.01f;
    public KeyCode teclaAsignadaA = KeyCode.A;
    float izquierda = -0.1f;
    float derecha = 0.1f;
    public KeyCode teclaAsignadaD = KeyCode.D;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0, velocidad, 0));
        if (Input.GetKeyDown(teclaAsignadaA))
        {
            this.transform.Translate(new Vector3(izquierda, 0, 0));
        }
        else if (Input.GetKeyDown(teclaAsignadaD))
        {
            this.transform.Translate(new Vector3(derecha, 0, 0));
        }
    }
}
