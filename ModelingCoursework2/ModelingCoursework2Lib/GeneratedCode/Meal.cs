﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Meal
{
	private Cook cook
	{
		get;
		set;
	}

	private Eater eater
	{
		get;
		set;
	}

	private string date
	{
		get;
		set;
	}

	private string status
	{
		get;
		set;
	}

	private Review reviewCook
	{
		get;
		set;
	}

	private Review reviewEater
	{
		get;
		set;
	}

	public virtual IEnumerable<Review> Review
	{
		get;
		set;
	}

	public virtual Eater Eater
	{
		get;
		set;
	}

	public virtual Cook Cook
	{
		get;
		set;
	}

	public virtual void addCookReview(string comment, Photo picture, int rating)
	{
		throw new System.NotImplementedException();
	}

	public virtual void addEaterReview(string comment, int rating)
	{
		throw new System.NotImplementedException();
	}

	public virtual void acceptMeal()
	{
		throw new System.NotImplementedException();
	}

	public virtual void rejectMeal()
	{
		throw new System.NotImplementedException();
	}

	public Meal(Cook cook, Eater eater, uint date)
	{
	}

}

