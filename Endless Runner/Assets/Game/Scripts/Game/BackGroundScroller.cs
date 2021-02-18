using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{

    public BackgroundInfo[] BackgroundInformations;

    void Start()
    {
        foreach (BackgroundInfo s in BackgroundInformations)
        {
            s.renderer = s.backgroundSprite.GetComponent<SpriteRenderer>();

            s.camera = Camera.main.gameObject;
            s.startPos = s.backgroundSprite.transform.position.x;
            s.length = s.renderer.bounds.size.x;
        }
    }
    private void FixedUpdate()
    {
        foreach (BackgroundInfo s in BackgroundInformations)
        {
            float temp = (s.camera.transform.position.x * (1 - s.parallaxEffect));
            float dist = (s.camera.transform.position.x * s.parallaxEffect);

                s.backgroundSprite.transform.position = new Vector3(s.startPos + dist, s.backgroundSprite.transform.position.y, s.backgroundSprite.transform.position.z);

            if (temp > s.startPos + s.length) s.startPos += s.length;
            else if (temp < s.startPos - s.length) s.startPos -= s.length;
        }
    }
}

[System.Serializable]
public class BackgroundInfo
{
    public string name;
    internal float length, startPos;
    internal SpriteRenderer renderer;
    public GameObject backgroundSprite;
    public GameObject camera;
    public float parallaxEffect;
    public float spacingLayer;
}
