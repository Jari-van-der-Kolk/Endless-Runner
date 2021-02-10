using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpable : MonoBehaviour
{
    [Header("Reference")]
    public AudioSource audioSource;

    private bool inCollider = false;

    private GameObject tempCollider;

    private SpriteRenderer gunSprite;
    private Aim aimScript;
    private Shoot shootScript;

    private void Start()
    {
        gunSprite = GetComponent<SpriteRenderer>();
        aimScript = GetComponent<Aim>();
        shootScript = GetComponent<Shoot>();

        aimScript.enabled = false;
        shootScript.enabled = false;
    }

    private void Update()
    {
        if (!inCollider) return;
        if (Input.GetKeyDown(KeyCode.E) && tempCollider.CompareTag("Player"))
        {
            PickUp(tempCollider);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inCollider = true;
        tempCollider = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inCollider = false;
    }

    private void PickUp(GameObject interactor)
    {
        audioSource.Play();

        gunSprite.sortingOrder = 1;
        transform.parent = interactor.transform;
        transform.position = interactor.transform.position + new Vector3(0.1f, 0, 0);

        aimScript.enabled = true;
        shootScript.enabled = true;
    }
}
