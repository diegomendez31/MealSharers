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

public class Administrator
{
	public string postcodeArea
	{
		get;
		set;
	}

	public string name
	{
		get;
		set;
	}

	public string phone
	{
		get;
		set;
	}

	public string username
	{
		get;
		set;
	}

	public string password
	{
		get;
		set;
	}
    public Administrator()
    {

    }

    public Administrator(String name, String phone, String username, String password, String postcodeArea)
    {
        this.name = name;
        this.phone = phone;
        this.username = username;
        this.password = password;
        this.postcodeArea = postcodeArea;
    }

}

