using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    int coin = 0;
    [SerializeField] Text coinsText;
    [SerializeField] AudioSource collectionSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coin++;
            Debug.Log("Coin: " + coin);
            coinsText.text = "Coin : " + coin;
            collectionSound.Play();
        }
    }
}
