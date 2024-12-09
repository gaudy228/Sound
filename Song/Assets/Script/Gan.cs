using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gan : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float offset;
    [SerializeField] private float KD;
    [SerializeField] private bool inKD = true;

    [SerializeField] private AudioSource shootSourse;
    
    private Vector3 mouse1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(mouse.y, mouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        mouse1 = mouse;
        mouse1.Normalize();
        shootSourse.panStereo = mouse1.x;
        
        if (Input.GetMouseButton(0) && inKD )
        {
            Instantiate(bullet, transform.position, transform.rotation);
            StartCoroutine(KDBetweenFire());
            shootSourse.Play();
        }
    }
    private IEnumerator KDBetweenFire()
    {
        inKD = false;
        yield return new WaitForSeconds(KD);
        inKD = true;
    }
}
