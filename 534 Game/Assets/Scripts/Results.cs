using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Results : MonoBehaviour {

    public Text[] texts;
    

	// Use this for initialization
	void Start () {
        //These varibales are for number for those who entered the country
        int PopDifference = CountryStats.Population - 7000000;
        texts[0].text = PopDifference + " people got into the country in this game";

        float HealthDifference = CountryStats.Healthcare - 30.00f;
        texts[1].text = HealthDifference + "% change in healthcare quality in this game";

        float GDPDifference = CountryStats.GDP - 1250.37f;
        texts[2].text = GDPDifference + " change in the GDP of the country in this game";


        //These variables are for numbers for those who where turned away from the country
        texts[3].text = CountryStats.PopOut.ToString() + " people were turned away from the country";
        texts[4].text = CountryStats.HealthOut.ToString() + "% change in healthcare was prevented because of your actions";
        texts[5].text = CountryStats.GDPOut.ToString() + " change in the GDP was prevented because of your actions";

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
