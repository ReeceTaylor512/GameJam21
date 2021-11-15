using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndergroundSwap : MonoBehaviour
{
    public GameObject overworld;
    public GameObject underground;
    //public GameObject underground;

    public BoxCollider2D ovrTrigger;
    public BoxCollider2D underTrigger;

    public Camera _camera;

    public Color overworldColor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        overworld.SetActive(true);
        underground.SetActive(false);

        _camera.backgroundColor = overworldColor;
    }



}
