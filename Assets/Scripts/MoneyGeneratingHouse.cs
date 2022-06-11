using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyGeneratingHouse : MonoBehaviour
{
    public float MoneyAmount;
    public Coins Money;
    public Animator CoinAnim;
    void Start()
    {
        Money = GameObject.FindObjectOfType<Coins>();
        InvokeRepeating("earnMoney", 1.0f, 1.0f);
    }
    public void earnMoney()
    {
        Money.CoinsInt += MoneyAmount;
        CoinAnim.Play("coinanim");
    }


    private void OnDisable()
    {
        CancelInvoke();
    }

    void Update()
    {

    }
}
