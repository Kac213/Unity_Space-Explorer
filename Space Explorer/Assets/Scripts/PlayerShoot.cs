using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Vector3 bulletOffset = new Vector3(0, 0.7f, 0);
    public float fireDelay = 0.25f;
    float cooldownTimer = 0;
    public GameObject bulletPrefab;
    int bulletLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bulletLayer = gameObject.layer;
    }

    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;
        if(Input.GetButton("Fire1") && cooldownTimer <= 0)
        {
            cooldownTimer = fireDelay;
            Vector3 offset = transform.rotation * bulletOffset;
            GameObject BulletGO = (GameObject)Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
            BulletGO.layer = gameObject.layer;
        }
    }
}
