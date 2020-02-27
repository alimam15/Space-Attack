using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] float backGroundScrollSpeed = 0.5f;
    [SerializeField] Material myMaterial;
    Vector2 offset;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(0f, backGroundScrollSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.mainTextureOffset += offset * Time.deltaTime;
    }
}
