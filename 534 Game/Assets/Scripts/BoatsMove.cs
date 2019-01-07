using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatsMove : MonoBehaviour {

    [Tooltip("the speed at which the boat can move")]
    public float speed;
    public bool entering;
    public bool interactable;
    public SpriteRenderer renderer;
    public Sprite[] sprites;
    private BoatVariables variables;
    public Management managementScript;


	// Use this for initialization
	void Start () {
        interactable = false;
        entering = true;
        variables = GetComponent<BoatVariables>();
        renderer = GetComponent<SpriteRenderer>();
        //Debug.Log(CountryStats.Population);
	}
	
	// Update is called once per frame
	void Update () {
        if (entering)
        {
            //Moves the boat towards the right side of the screen
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            
        }

        if (!entering)
        {
            //Moves the boat away from the right and flips the sprite to suit moving direction
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            renderer.flipX = true;
        }

        if(entering == true && interactable == true)
        {
            renderer.sprite = sprites[1];
        }

        if(entering == false || interactable == false)
        {
            renderer.sprite = sprites[0];
        }

        if(transform.position.x > 15.00f)
        {
            //Debug.Log("Boat has entered the country and changed the stats");
            CountryStats.Population = CountryStats.Population + variables.people;
            CountryStats.Healthcare = CountryStats.Healthcare + variables.healthAffect;
            CountryStats.GDP = CountryStats.GDP + variables.GDP_Affect;
            int chance = Random.Range(0, 100);
            Debug.Log(chance);
            if (chance <= 1)
            {
                managementScript.attack = true;
            }
            Destroy(gameObject);
        }

        if (transform.position.x < -25.00f)
        {
            /*This adds the variables to the static variables of the numbers turned away*/
            CountryStats.PopOut = CountryStats.PopOut + variables.people;
            CountryStats.HealthOut = CountryStats.HealthOut + variables.healthAffect;
            CountryStats.GDPOut = CountryStats.GDPOut + variables.GDP_Affect;

            Destroy(gameObject);
        }
    }


}
