using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

    public Quaternion rotation = Quaternion.identity;
    public bool apply = false;
    public Transform joint = null;
    public Transform bone = null;
    public bool reset = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (joint != null && bone != null)
        {
            if (this.apply)
            {
                this.transform.rotation = Quaternion.Inverse(joint.transform.localRotation) * rotation * joint.transform.localRotation;
                if(this.reset)
                {
                    this.transform.rotation = bone.localRotation;
                }
            }
            else
            {
                if(this.reset)
                {
                    rotation = Quaternion.Inverse(bone.localRotation);
                    this.reset = false;
                }
            }
        }
        else
        {
            this.rotation = this.transform.rotation;
        }
	}
}
