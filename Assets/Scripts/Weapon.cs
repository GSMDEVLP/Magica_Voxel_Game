using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float damage = 21;
    public float fierRate = 1; // скорость стрельбы
    public float range = 15; // дальность стрельбы
    public ParticleSystem muzzleFlash;
    public Transform bulletSpawn;
    public AudioClip shotFx; // звук
    public AudioSource _audioSource; // источник звука


    public Camera _cam;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }


    void Shoot()
    {
        _audioSource.PlayOneShot(shotFx);
        //Instantiate(muzzleFlash, bulletSpawn.position, bulletSpawn.rotation);
        muzzleFlash.Play();

        RaycastHit hit;

        if (Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range)) // что ээто значит -  берем позицию камеры, далее берем определенной напрвление камеры OY, считываем все в переменную hit, и огрничиваем ее range                   
        {
            Debug.Log("Nice shoot");
        }
    }
}
