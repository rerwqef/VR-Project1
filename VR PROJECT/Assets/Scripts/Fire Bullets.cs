using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FireBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform ShootPoint;
    public float fireSpeed = 30;
    void Start()
    {
        XRGrabInteractable grabbable=GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(fire);
    }
    public void fire(ActivateEventArgs args)
    {
        GameObject spawnbullet=Instantiate(bulletPrefab);
        spawnbullet.transform.position=ShootPoint.position;
        spawnbullet.GetComponent<Rigidbody>().velocity=ShootPoint.forward*fireSpeed;
        Destroy(spawnbullet, 5);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
