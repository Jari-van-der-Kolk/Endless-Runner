using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{

    private new BoxCollider2D collider;
    [SerializeField]private GameObject player;

    private float width;


    private void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        player = GameObject.FindGameObjectWithTag("Player");

        width = collider.size.x;
        collider.enabled = false;

    }

    void Update()
    {
        if (player.transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(player.transform.position.x + width, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
        Debug.DrawLine(player.transform.position, player.transform.position + new Vector3(width, 0, 0));
    }

   
}
