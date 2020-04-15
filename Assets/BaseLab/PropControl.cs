using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropControl : MonoBehaviour {


	private GameObject poi;
	private GameObject staff;
	private GameObject sstaff;
	private GameObject fan;
	private GameObject hoop;
	private GameObject hoop8;
	private GameObject ring8;
	private GameObject furet;
	private GameObject eccentric;
	private GameObject club;

	public StringType propTypeString; 

	public StringReference propType;

	// Use this for initialization
	void Start () {
		propType.constantValue = propTypeString.propType; 

		poi = gameObject.transform.Find("Poi").gameObject;
		staff = gameObject.transform.Find("Staff").gameObject;
		sstaff = gameObject.transform.Find("SStaff").gameObject;
		ring8 = gameObject.transform.Find("8Ring").gameObject;
		hoop8 = gameObject.transform.Find("8Hoop").gameObject;
		hoop = gameObject.transform.Find("Hoop").gameObject;
		fan = gameObject.transform.Find("Fan").gameObject;
		furet = gameObject.transform.Find("Furet").gameObject;
		eccentric = gameObject.transform.Find("Eccentric").gameObject;
		club = gameObject.transform.Find("Club").gameObject;
		//poi = GameObject.Find("/" + prop.name + "/Poi");

		init(); 
	}
	

	public void init() {
		poi.SetActive(false);
		staff.SetActive(false);
		sstaff.SetActive(false);
		ring8.SetActive(false);
		hoop8.SetActive(false);
		hoop.SetActive(false);
		fan.SetActive(false);
		furet.SetActive(false);
		eccentric.SetActive(false);
		club.SetActive(false);

		if(propType.value.ToLower().Equals("staff"))
		{ staff.SetActive(true); }
		else if(propType.value.ToLower().Equals("sstaff"))
		{ sstaff.SetActive(true); }
		else if(propType.value.ToLower().Equals("8ring"))
		{ ring8.SetActive(true); }
		else if(propType.value.ToLower().Equals("8hoop"))
		{ hoop8.SetActive(true); }
		else if(propType.value.ToLower().Equals("hoop"))
		{ hoop.SetActive(true); }
		else if(propType.value.ToLower().Equals("fan"))
		{ fan.SetActive(true); }
		else if(propType.value.ToLower().Equals("furet"))
		{ furet.SetActive(true); }
		else if(propType.value.ToLower().Equals("eccentric"))
		{ eccentric.SetActive(true); }
		else if(propType.value.ToLower().Equals("club"))
		{ club.SetActive(true); }
		else {
			poi.SetActive(true);
		}
	}


	// Update is called once per frame
	void Update () {
		
	}
}
