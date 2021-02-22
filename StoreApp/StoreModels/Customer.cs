using System;
/* 
Class members:
in java: 
    fields, constructors, methods, getters & setters
in c#:
    fields, properties, methods, constructors
    fields - characteristics of your object
    methods - behavior of your object
    constructors - special method, that gets called when you create an instance of an object
    - if there exists no constructor, there's a default one that gets created for you
    properties - "smart fields"
        - in java you need to have a field for a getter and setter to exist
        - wrapper for a field, works as a getter and setter for a private backing field

POCO - plain c# object 
    - class that holds data 
 */
namespace StoreModels
{
    /// <summary>
    /// Data structure used for modeling a hero.
    /// </summary>
    public class Customer
    {
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value == null || value.Equals(""))
                {
                    throw new ArgumentNullException("Customer name can't be empty or null");
                }
                customerName = value;

            }
        }
        // public int HP { get; set; }
        // public Element ElementType { get; set; }
        // public SuperPower SuperPower { get; set; }

        public override string ToString() => $"Customer Details: \n\t name: {this.CustomerName}";
    }
}
