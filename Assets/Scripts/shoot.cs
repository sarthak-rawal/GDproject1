using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shootq();
        }

        void Shootq()
        {

            Instantiate(bulletPrefab, firePoint.transform.position, firePoint.rotation);
        }
    }
}
