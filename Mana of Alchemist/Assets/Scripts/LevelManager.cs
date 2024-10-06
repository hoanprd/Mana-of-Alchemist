using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int currency;

    private void Awake()
    {
        main = this;
    }

    // Start is called before the first frame update
    private void Start()
    {
        currency = 100;
    }

    public void IncreaseCurrency (int amount)
    {
        currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
        if (amount <= currency)
        {
            currency -= amount;
            return true;
        }
        else
        {
            Debug.Log("You do not have enough money");
            return false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
