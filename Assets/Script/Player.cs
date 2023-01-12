using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int  initialHealth = 100;
    // private int health;

    public int Health
    {
        get;
        private set;
    
    }

private void  Awake()
{
    Health = initialHealth;
}

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
