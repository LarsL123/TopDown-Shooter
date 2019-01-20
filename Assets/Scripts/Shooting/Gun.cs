using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 5f;

    public Transform shootFrom;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffekt;

    private float nextTimeToFire = 0;

	void Update () {

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
        }

	}

    private void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;

        //Shooting the ray.
        if(Physics.Raycast(shootFrom.transform.position, shootFrom.transform.forward, out hit, range))
        {
            //Deal damage when that system is implemented.
            Debug.Log(hit.transform.name);

            //Spawning the impact effect.
            GameObject inpactObject = Instantiate(impactEffekt, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(inpactObject, 2f);

        }
        

         
    }

   
}
