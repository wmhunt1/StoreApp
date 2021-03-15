## Functionality:
* Add a new customer : Check
* Search customers by name : Check
* Display details of an order : Check
* Place orders to store locations for customers : Check
* View order history of customer
* View order history of location
* View location inventory
* The customer should be able to purchase multiple products
* Order histories should have the option to be sorted by date (latest to oldest and vice versa) or cost (least expensive to most expensive)
* The manager should be able to replenish inventory

## Models:
* Customer : Check
* Location : Check
* Orders : Check
* Product : Check
#### Note: add as much models as you would need for your design

## Additional requirements:
* Exception Handling
* Input validation
* Logging (useful ones)
* At least 20 unit tests:
  * Use Moq and Sqlite for testing
  * DB methods should be tested
* Data should be persisted, (no data should be hard coded) : Check
  * You should use PostgreSQL DB : Check
  * Use code first approach to establish a connection to your DB : Check
* WebApp should be deployed using Azure App Services : Check
* A CI/CD pipeline should be established use Azure Pipelines
* Use ASP.NET MVC for the UI : Check
* DB structure should be 3NF : Check
  * Should have an ER Diagram : Check
* Code should have xml documentation

Tech Stack:
* C#
* PostgreSQL DB
* EF Core
* Xunit
* Serilog or Nlog
* Azure 
* Azure DevOps
* ASP.NET MVC