using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{
    // Start is called before the first frame update
      private int actualHealth;
    private string ourtext;
    private TextMeshProUGUI textHpinfo;
    void Start()
    {
        textHpinfo = GameObject.Find("HPinfo").GetComponent<TextMeshProUGUI>();

        actualHealth = GameObject.Find("OurPlayer").GetComponent<Player>().Health;

        textHpinfo.text += actualHealth;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
