using System;

namespace DogClass
{


//3. Write a dog class and initialize an instance of the class
public class Session2Homework_DogClass
{
	//Variables
	string name;
	string color;
	int age;
	float weight;

	//Constructor
	public Session2Homework_DogClass(string _name, int _age)
	{
		name = _name;
		age = _age;
		SetClothing();
	}

	//Behaviors (Functions)
	public string GetName()
    {
		return name;
    }

	public float GetWeight (float _weight)
    {
		return weight = _weight;
    }

	private void Sleep()
    {
		//Action
		//Action
		//Action
    }

	public void SetClothing()
    {
		//Set some random clothing for dog
    }

}
}
