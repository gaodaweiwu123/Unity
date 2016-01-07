using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    protected float jump_speed = 12.0f;
    public bool is_landing = false;
	// Update is called once per frame
	void Update () {
        
	    if(this.is_landing){
            if (Input.GetMouseButtonDown(0))
            {
                this.GetComponent<Rigidbody>().velocity = Vector3.up * this.jump_speed;
            }
        }
	}
    void Start()
    {
        this.is_landing = false;
    }
    void OnCollisionEnter(Collision collision)
     {
        if (collision.gameObject.tag =="Floor") {
        this.is_landing = true;
        }
        
     }
    
}
