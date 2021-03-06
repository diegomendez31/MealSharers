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
	public Cook cook
	{
		get;
		set;
	}

	public Eater eater
	{
		get;
		set;
	}

	public string date
	{
		get;
		set;
	}
    public string food
    {
        get;
        set;
    }
	public string status
	{
		get;
		set;
	}

	public Review reviewCook
	{
		get;
		set;
	}

	public Review reviewEater
	{
		get;
		set;
	}

    public bool IsReview
    {
        get;
		set;
	
    }
    public bool IsReviewCook
    {
        get;
        set;

    }

    public bool IsAccepted
    {
        get;
        set;

    }


	public virtual void addCookReview(Review rev)
	{
        reviewCook = rev;
        eater.calculateRating(rev.rating);
        IsReviewCook = true;
       
	}

	public virtual void addEaterReview(Review rev)
	{
        reviewEater = rev;
        cook.calculateRating(rev.rating);
        IsReview = true;
	}

	public virtual void acceptMeal()
	{
        this.status = "OK";
        IsAccepted = true;
	}

	public virtual void rejectMeal()
	{
        this.status = "Rejected";
	}

	public Meal(Cook cook, Eater eater, String date, String food)
	{
        this.cook = cook;
        this.eater = eater;
        this.date = date;
        this.food = food;
        this.status = "Awaiting";
        IsReview = false;
        IsAccepted = false;
        eater.numberMeals = eater.numberMeals+1;
	}

    public override string ToString()
    {
        return "Cook: " + cook.name + " Eater: " + eater.name + "/n" + "Kind of food: " + food;      
    }

}

