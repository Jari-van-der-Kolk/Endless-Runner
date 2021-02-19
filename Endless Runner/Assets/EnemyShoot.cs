using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [Header("Properties")]
    public Transform firePoint;
    public LineRenderer lineRenderer;
    public AudioSource audioSource;
    public GameObject mainPlayer;
    public LayerMask layerMask;


    private float timer;
    private float fireRate = 3f;

    void Update()
    {
        if (Time.timeScale == 0) return;

        Aim();

        timer += Time.deltaTime;

        if (timer >= fireRate)
        {
            StartCoroutine(Shot());

            timer = 0;
        }
    }

    void Aim()
    {
        Vector3 difference = mainPlayer.transform.position - transform.position;
        difference.Normalize();
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ + 0);
    }

    IEnumerator Shot()
    {
        audioSource.Play();

        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right, Mathf.Infinity, layerMask);

        if (hitInfo)
        {
            if (hitInfo.collider.gameObject.CompareTag("Player"))
            {
                hitInfo.collider.GetComponent<Health>().ModifyHealth(25);
            }

            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitInfo.point);
        }
        else
        {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        lineRenderer.enabled = true;

        yield return new WaitForSeconds(0.02f);

        lineRenderer.enabled = false;
    }
}

