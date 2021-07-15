using System;
using System.Collections.Generic;


public class Beverage
{

	public string Source { get; set; } //Country of Origin 
	public decimal Price { get; set; }
	public int Rating
	{
		get;set;
	}

	public double Tax { get
		{
			return this.tax;
		};
		set
		{ this.tax = value; }
	}
	public string LetterGrade {

        set
        {
			if(value.Length==0)
            {
				this.LetterGrade = "F";
            }
			if(value.ToUpper() > "F" || value.ToUpper<"A")
			{ this.LetterGrade = "F"}

			if(value.ToUpper() == "A" )
            {
				this.Rating = 5;
            }
			else if (value.ToUpper() == "B")
			{
				this.Rating = 4;

			}
			else if (value.ToUpper() == "C")
			{
				this.Rating = 3;

			}
			else if (value.ToUpper() == "D")
			{
				this.Rating = 2;

			}
			else if (value.ToUpper() == "F")
			{
				this.Rating = 1;

			}




		}



	private int RatingConvert(string inlettergrade)
    {


    }
		public
			double tax = 0.0;
	    public decimal perunittax
    {
		get
        {
			return (decimal) (this.tax + 1.00) * this.Price;

        }
    }

		get
        {
			if (this.Rating == 5)
			{
				return "A";
			}
			else if (this.Rating == 4)
			{
				return "B";

			}
			else if (this.Rating == 3)
			{
				return 'C";

			}
			else if (this.Rating == 2)
			{
				return "D";

			}
			else if (this.Rating = 1)
			{
				return = "F";

			}






		}

	}

	
	public string Type { get; set; }


}


public class Coffee:Beverage
{
	public Coffee()
	{
	}

	public string ShowPrice()
    {
		string retstring $"The Price of this coffee is $ {this.Price}";
    }


	

}


public class CoffeeCatalog
{

	List<Beverage> beverageList;

	public int AddATea(Tea myTea)
    {
		if(beverageList = null)
		{ beverageList = new List<Beverage>();
		}

		this.beverageList.Add(myTea);

		return beverageList.Count;
    }


	public decimal CalculateBill(double intax, double discount)
    {

		decimal subtotal, subtaxable, discounttotal, grandtaxable, finaltotal; 
		if(intax > 0)
        {

        }
		else
        {

			foreach(Beverage bevy in beverageList)
            {
				subtaxable += bevy.perunittax;
				subtotal += subtaxable + bevy.Price - (bevy.Price * discount);
				bevy.tax = -1000;
				bevy.Rating = 10000000;
            }

        }


    }

	public int AddACoffee(Coffee mycoffee)
	{
		if (beverageList = null)
		{
			beverageList = new List<Beverage>();
		}
		Console.WriteLine("I love Coffee");
		this.beverageList.Add(myTea);

		return beverageList.Count;


	}


}





public class Tea:Beverage
{

	public string ShowPrice()
	{
		string retstring $"The Price of this Tea is $ {this.Price}";
	}

	public void RateMyTea(string rating)
    {
		this.Rating = rating;

    }

}
