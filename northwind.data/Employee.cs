//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Northwind.Data
{
    using System;
    using System.Collections.Generic;using Asya.Util.Wpf.Common.Library.Entity;
    
    public partial class Employee :  BaseEntity
    {
        public Employee()
        {
            this.Orders = new HashSet<Order>();
        }
    
        private int _employee_ID;
    	public int Employee_ID 
    	{ 
    		get { return _employee_ID; } 
    		set
    		{
    			if (value != _employee_ID) {
    				_employee_ID = value;
    				 OnPropertyChanged("Employee_ID");
    			}
    		} 
    	}
    
        private string _last_Name;
    	public string Last_Name 
    	{ 
    		get { return _last_Name; } 
    		set
    		{
    			if (value != _last_Name) {
    				_last_Name = value;
    				 OnPropertyChanged("Last_Name");
    			}
    		} 
    	}
    
        private string _first_Name;
    	public string First_Name 
    	{ 
    		get { return _first_Name; } 
    		set
    		{
    			if (value != _first_Name) {
    				_first_Name = value;
    				 OnPropertyChanged("First_Name");
    			}
    		} 
    	}
    
        private string _title;
    	public string Title 
    	{ 
    		get { return _title; } 
    		set
    		{
    			if (value != _title) {
    				_title = value;
    				 OnPropertyChanged("Title");
    			}
    		} 
    	}
    
        private Nullable<System.DateTime> _birth_Date;
    	public Nullable<System.DateTime> Birth_Date 
    	{ 
    		get { return _birth_Date; } 
    		set
    		{
    			if (value != _birth_Date) {
    				_birth_Date = value;
    				 OnPropertyChanged("Birth_Date");
    			}
    		} 
    	}
    
        private Nullable<System.DateTime> _hire_Date;
    	public Nullable<System.DateTime> Hire_Date 
    	{ 
    		get { return _hire_Date; } 
    		set
    		{
    			if (value != _hire_Date) {
    				_hire_Date = value;
    				 OnPropertyChanged("Hire_Date");
    			}
    		} 
    	}
    
        private string _address;
    	public string Address 
    	{ 
    		get { return _address; } 
    		set
    		{
    			if (value != _address) {
    				_address = value;
    				 OnPropertyChanged("Address");
    			}
    		} 
    	}
    
        private string _city;
    	public string City 
    	{ 
    		get { return _city; } 
    		set
    		{
    			if (value != _city) {
    				_city = value;
    				 OnPropertyChanged("City");
    			}
    		} 
    	}
    
        private string _region;
    	public string Region 
    	{ 
    		get { return _region; } 
    		set
    		{
    			if (value != _region) {
    				_region = value;
    				 OnPropertyChanged("Region");
    			}
    		} 
    	}
    
        private string _postal_Code;
    	public string Postal_Code 
    	{ 
    		get { return _postal_Code; } 
    		set
    		{
    			if (value != _postal_Code) {
    				_postal_Code = value;
    				 OnPropertyChanged("Postal_Code");
    			}
    		} 
    	}
    
        private string _country;
    	public string Country 
    	{ 
    		get { return _country; } 
    		set
    		{
    			if (value != _country) {
    				_country = value;
    				 OnPropertyChanged("Country");
    			}
    		} 
    	}
    
        private string _home_Phone;
    	public string Home_Phone 
    	{ 
    		get { return _home_Phone; } 
    		set
    		{
    			if (value != _home_Phone) {
    				_home_Phone = value;
    				 OnPropertyChanged("Home_Phone");
    			}
    		} 
    	}
    
        private string _extension;
    	public string Extension 
    	{ 
    		get { return _extension; } 
    		set
    		{
    			if (value != _extension) {
    				_extension = value;
    				 OnPropertyChanged("Extension");
    			}
    		} 
    	}
    
        private byte[] _photo;
    	public byte[] Photo 
    	{ 
    		get { return _photo; } 
    		set
    		{
    			if (value != _photo) {
    				_photo = value;
    				 OnPropertyChanged("Photo");
    			}
    		} 
    	}
    
        private string _notes;
    	public string Notes 
    	{ 
    		get { return _notes; } 
    		set
    		{
    			if (value != _notes) {
    				_notes = value;
    				 OnPropertyChanged("Notes");
    			}
    		} 
    	}
    
        private Nullable<int> _reports_To;
    	public Nullable<int> Reports_To 
    	{ 
    		get { return _reports_To; } 
    		set
    		{
    			if (value != _reports_To) {
    				_reports_To = value;
    				 OnPropertyChanged("Reports_To");
    			}
    		} 
    	}
    
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}