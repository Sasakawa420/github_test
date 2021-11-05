using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BButton : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip cymbal;
    [SerializeField] GameObject effectPrefab;
    [SerializeField] Transform effectPosition;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        
    public void PressBButton()
    {
        audioSource.PlayOneShot(cymbal);
        Instantiate(effectPrefab, effectPosition);
    }
}
