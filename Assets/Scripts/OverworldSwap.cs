using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldSwap : MonoBehaviour
{
    public GameObject overworld;
    public GameObject underground;
    //public GameObject underground;

    public BoxCollider2D ovrTrigger;
    public BoxCollider2D underTrigger;

    public Camera _camera;

    public static bool overworldActive = true;
    public static bool undergroundActive = false;

    public Color undergroundColor; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        undergroundActive = true;
        overworldActive = false;
        overworld.SetActive(false);
        underground.SetActive(true);
            
        _camera.backgroundColor = undergroundColor;

    }

    
    
}
