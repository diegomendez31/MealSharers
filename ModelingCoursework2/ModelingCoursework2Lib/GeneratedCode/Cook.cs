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

public class Cook : User
{
	private string PVGstatus
	{
		get;
		set;
	}

	private string hygieneStatus
	{
		get;
		set;
	}

	private string hygieneExpiryDate
	{
		get;
		set;
	}

	private string PVGIssueDate
	{
		get;
		set;
	}

	public virtual Cook register(string name, string address, string phone, string foodPrefer, string transport, string statusPVG, string hygieneCertificate)
	{
		throw new System.NotImplementedException();
	}

	public virtual bool isHygieneExpiring()
	{
		throw new System.NotImplementedException();
	}

}

