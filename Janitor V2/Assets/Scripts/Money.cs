using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {
	int money = 80;
	Text Total;
	[SerializeField]
	public Toggle rentToggle;
	public Toggle foodToggle;
	public Toggle MedicineToggle;
	bool RentTaken;
	bool  foodTaken;
	bool medicineTaken;
	void Start(){
		Total = GetComponent<Text> ();
		RentTaken = false;
		foodTaken = false;
		medicineTaken = false;
	}

	void Update()
	{
		if (rentToggle.isOn && RentTaken == false) {

			money -= 25;
			RentTaken = true;
		
		}
		else if(!rentToggle.isOn && RentTaken == true)
		{
			money += 25;
			RentTaken = false;
		}
		if (foodToggle.isOn && foodTaken == false) {

			money -= 20;
			foodTaken = true;

		}
		else if(!foodToggle.isOn && foodTaken == true)
		{
			money += 20;
			foodTaken = false;
		}
		if (MedicineToggle.isOn && medicineTaken == false) {

			money -= 10;
			medicineTaken = true;

		}
		else if(!MedicineToggle.isOn && medicineTaken == true)
		{
			money += 10;
			medicineTaken = false;
		}

		Total.text = money.ToString();
	}


}
