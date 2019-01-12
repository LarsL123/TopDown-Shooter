using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;

    public Transform shootFrom;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffekt;
	
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
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

        }
        //Spawning the impact effect.
        GameObject inpactObject = Instantiate(impactEffekt, hit.point, Quaternion.LookRotation(hit.normal));

        Destroy(inpactObject, 2f); 
    }

   
}
