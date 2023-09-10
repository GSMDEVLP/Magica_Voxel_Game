using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int ScoreAt = 10;
    public AudioClip PickupSFX;
    public GameObject PickupEffect;
    AudioSource SoundSource;

    private MeshRenderer _mesh;

    private void Start()
    {
        SoundSource = GetComponent<AudioSource>();
        _mesh = GetComponent<MeshRenderer>();
    }
    void OnTriggerEnter(Collider other)
    {
        // когда игрок входит в зону
        // ему добавится Х очков
        // проиграть звук подбора монетки
        // включить визуальный эффект
        // монетка удаляется

        if(other.tag == "Player")
        {
            SoundSource.PlayOneShot(PickupSFX);
            other.GetComponent<PlayerScript>().Score += ScoreAt;

            _mesh.enabled = false;
            GameObject VFX = Instantiate(PickupEffect, transform.position, transform.rotation);
            Destroy(VFX, 1f);
            Destroy(gameObject, 1f);
        }
    }

}
