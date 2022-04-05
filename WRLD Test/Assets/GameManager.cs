using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager inst;
    public GameObject mussle;
    public GameObject bulletPrefab;
    GameObject bullet;
    float nextFire = 5.0f;
    float fireRate = 1.0f;
    private void Awake()
    {
        inst = this;
    }
    private void Update()
    {
        
        if (Input.GetKey(KeyCode.Return) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;

            bullet = Instantiate(bulletPrefab, mussle.transform.position, mussle.transform.rotation);
            Destroy(bullet, 5f);
        }
        if (bullet!=null)
        {
            if (!GameObject.FindGameObjectWithTag("Enemy"))
            {
                Destroy(bullet);
                return;
            }
            bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, GameObject.FindGameObjectWithTag("Enemy").transform.position, 50 * Time.deltaTime);
        }
    }
}
