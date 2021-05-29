using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SomPassos : MonoBehaviour
{
    public AudioClip PassosSom;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(PassosSom, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
