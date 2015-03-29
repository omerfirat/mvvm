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
    
    public partial class Category :  BaseEntity
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
    
        private int _category_ID;
    	public int Category_ID 
    	{ 
    		get { return _category_ID; } 
    		set
    		{
    			if (value != _category_ID) {
    				_category_ID = value;
    				 OnPropertyChanged("Category_ID");
    			}
    		} 
    	}
    
        private string _category_Name;
    	public string Category_Name 
    	{ 
    		get { return _category_Name; } 
    		set
    		{
    			if (value != _category_Name) {
    				_category_Name = value;
    				 OnPropertyChanged("Category_Name");
    			}
    		} 
    	}
    
        private string _description;
    	public string Description 
    	{ 
    		get { return _description; } 
    		set
    		{
    			if (value != _description) {
    				_description = value;
    				 OnPropertyChanged("Description");
    			}
    		} 
    	}
    
        private byte[] _picture;
    	public byte[] Picture 
    	{ 
    		get { return _picture; } 
    		set
    		{
    			if (value != _picture) {
    				_picture = value;
    				 OnPropertyChanged("Picture");
    			}
    		} 
    	}
    
    
        public virtual ICollection<Product> Products { get; set; }
    }
}