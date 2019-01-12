using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerCustom : MonoBehaviour {

    public float maxSpeed = 20;
    public float movementSpeed = 10;
    Rigidbody m_rigidbody;
    


    private void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    //Very badly coded. I dont like to do player movment so this is just temporary!
    void Update () {
        float totalX = Input.GetAxisRaw("Vertical") * movementSpeed;
        float totalZ = -Input.GetAxisRaw("Horizontal") * movementSpeed;

        if (totalX != 0)
        {
            totalX += m_rigidbody.velocity.x;
        }

        if (totalZ != 0)
        {
            totalZ += m_rigidbody.velocity.z;
        }

       
        if (totalX > maxSpeed)
        {
            totalX = maxSpeed;
        }else if (totalX < -maxSpeed)
        {
            totalX = -maxSpeed;
        }

        if (totalZ > maxSpeed)
        {
            totalZ = maxSpeed;
        }else if(totalZ < -maxSpeed){
            totalZ = -maxSpeed;
        }

        Vector3 speed = new Vector3(totalX, 0f , totalZ);

        m_rigidbody.velocity = speed;

    }

    public void SetPlayerDirection(Vector2 direction)
    {
        //the direction is in 2d space, so i have tyo convert to 3d:
        Quaternion rotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.y));
        transform.rotation = rotation;
    }

}
