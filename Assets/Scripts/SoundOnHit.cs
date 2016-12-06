using UnityEngine;
using System.Collections;

public class SoundOnHit : MonoBehaviour {

    public AudioClip hitClip;
    private AudioSource source;

	// Use this for initialization
	void Start () {
        source = gameObject.AddComponent<AudioSource>();
        source.spatialBlend = 1.0f;
        source.clip = hitClip;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.relativeVelocity.magnitude > .1)
        {
            source.Play();
        }
    }
}
