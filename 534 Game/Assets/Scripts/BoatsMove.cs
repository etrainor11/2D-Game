using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatsMove : MonoBehaviour {

    [Tooltip("the speed at which the boat can move")]
    public float speed;
    public bool entering;
    public SpriteRenderer renderer;

    private BoatVariables variables;
    

	// Use this for initialization
	void Start () {
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

        if(transform.position.x > 15.00f)
        {
            //Debug.Log("Boat has entered the country and changed the stats");
            CountryStats.Population = CountryStats.Population + variables.people;
            CountryStats.Healthcare = CountryStats.Healthcare + variables.healthAffect;
            CountryStats.GDP = CountryStats.GDP + variables.GDP_Affect;
            Destroy(gameObject);
        }

        if (transform.position.x < -25.00f)
        {
            Debug.Log("A boat has passed far off to the left and has now been destroyed");
            Destroy(gameObject);
        }

        

    }


}
