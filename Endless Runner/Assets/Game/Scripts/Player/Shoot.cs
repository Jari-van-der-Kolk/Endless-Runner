using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Header("Properties")]
    public Transform firePoint;
    public LineRenderer lineRenderer;
    public AudioSource audioSource;

    private bool canFire = true;

    void Update()
    {
        if (Time.timeScale == 0) return;

        if (Input.GetMouseButtonDown(0) && canFire)
        {
            StartCoroutine(Shot());
        }
    }

    IEnumerator Shot()
    {
        canFire = false;

        audioSource.Play();

        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        if (hitInfo)
        {
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

        yield return new WaitForSeconds(1f);

        canFire = true;
    }
}
