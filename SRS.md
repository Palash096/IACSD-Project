
# Mart Inventory

## Document:
System Requirement Specification Document

## Title:
System Reqruiement Spefication for Mart Inventory Application

## Team: 
Direct Customer,Indirect Customer, Architect,Business Analyst,	Quality Assurance Team, System Analyst

## Objective (Purpose):
Mart Inventory is a web application.
It provides a platform that will automate various tasks associated with handiling product catalog.
Execution of proper billing system.
Better organizing the stored information and optimum performance.
Helping the business to ensure smooth working of the process.

## Scope:
This System allows Clients to maintain thier products for adding or removing from catalog based on their availablity.
Manager will be able to review orders history and may able to cancel order within 24 hours,order place.
The System  will be able to show live Bussion Operation statistics trends through Customized dashboard for manager/owner.
The system wiil enable to do transactions and produce bills for products in a specified format for customer.


## Definitions:
	MI: Mart Inventory
	QA:  Quality Assurance
	Portal: Peronalized Online Web Application
	MIS: Management Information System
	CRM: Customer Relation Managment
	BI:  Business Intelligence
	KPI:Key Perfomornace I
	Dashboard: Personalized information presented using  BI techniques such grid, score card, graph, KPI


## Functional Requirements:

Any Working staff will be able to view different products avaialble for sale. Any staff will be able select product to view from categories avaialble.
Registered Vendors will be able promote thier product for sale by adding  products to the product catalog maintained by System.
Managers will be able to approve or reject request for adding or removing products from product catalog by Vendors.
 Manager will be to track and maintain stock of products available for sale. Staff will be able to raise request for product updatation from product inventory maintain by manager.

Vendors will be able request to add new product to product catalog maintained by Manager.
Manager will be able to approve or reject request  raised by staff/vandors for adding or removing products from product catalog.

Manager will be able to update  product details which have been already added to product catalog.
Staff will inform manager and  vendors will be informed well in advaned about low stock  or out of stock of products in product catalog.
Product listing will be provided based their category, sale, quantity, likes, recommendations.
System will maintain shopping cart/basket for each customer to maintain list of items selected by him/her. Consumer will be able view all items from shopping cart. Shopping Cart will present product details, number of items of product selected by consumer with price and total. Consumer will be able procees for Order placement.
Registered Customer will be able to return products within 7 days. Registered customer get orders history.
Manager will be able get details of orders of a particular Customer. Manager will be able to cancel , reject or approve orders been placed by consumer due to some policies of Business.
Mart Owner will be able to summary of orders been placed , rejected from Order Processing of System. Mart Owner/Manager will get Business insight by observing  daily operations  with the of getting orders information.
Customer will be provided options for payment such as through internet banking  or  UPI  or Online payment option.
Customer will asked to submit their payment related information.Customer will be redirected to payment gateway for secure payment transaction.On successful payment processing using payment gateway system will notify consumer about transaction and order placement status.
Delivery vendor will be ablt to  list all product delivery to be done by their staff.
Manager will be able to monitor shipment  done by their vendors.
Customer will able to submit feedback about product they buy. Customer will able to  get details about product orders placed.
Staff  will be to manage his profile maintained by system. Staff will be able change his credentails if required. 
Manager  will be to manage his profile maintained by system. Manager will be able change his credentails if required.
Customer will be notified about bill status, through  SMS, Email communication.
Customer will be notified about the specific products through SMS, Email communication.
System will present dashboard for Vendors, Manager, Staff as well as Mart Owner.
Dashboard will provide information using graph, score cards, key perfomance indicators as well Grid data prestation.
Mart Owner/Manager will be informed about bussiness operations through reports.
System will generate report of transactions based on daily, weekly, monthly in pdf format.

	
## NonFunctional Requirement:

### Security
Registered Customer will allowed to place an order.	
Each stakeholder will be to access system  through authentication process. Who are you ?
System will provide access to  the content , operations using Role based security (Authorization) (Permissions based on Role)
Using SSL in all transactions  which will be performed stakeholder. It would protect confidential information shared by system to stake holder of Shared by stakeholder to system.
System will automatically log of  all stakeholder after some time due to inactiveness.
System will block operations for inactive  stakeholder and would redirect for authentication.
System  will internally maintain secure communiction channel between Servers ( Web Servers, App Servers, databse Server)
Sensitive data will be always encrypted across communcation.
User proper firewall to protect servers from out side fishing, velnerable attacks.


### Reliability
The system will backup business data on regular basis and recover in short time duration to keep system operational
Continous updates are matained , continous Adminstration is done to keep system operational.
During peak hours system will maintain same user experaince by managing load balacning .

### Availability
uptime:   24* 7  available  99.999%
	
### Maintainability:
A Commercial database software will be used to maintain System data Persistence.
A readymade Web Server will be installed to host online shopping portal (Web Site) to management server capabilities.
IT operations team will easily monitor and configure System using Adminstrative tools provided by Servers.
Separate enviornment will be maintained for system for isolation in  production, testing, and development.

### Portablility:
PDA: Portable Device Application
System will provide portable User Interface ( HTML, CSS, JS) through  users will be able to access online shopping portal.
System can be deployed to single server, multi server, to any OS, Cloud (Azure or AWS or GCP)

### Accessibility:
only registered customer will be able to place an order after authentication.
Sales team can reject or approve  orders, shopper requests  based on role  provided.
BOD team will be able to view daily, weekly, monthly, annual businss Growth throgh customized dashboard.
Shoppers will be able to see their product sale graph

### Durability:
System will retain customer  shopping cart for 15 minutes  even though customer loose internet connection and join again.
System will maintain wishlist for customer . customer  will be able to add products from wishlist  and add to shopping cart whenever needed.
System will implement backup and recovery for retaining stake holders data, bussiness operation data and business data over time.

### Efficiency:
on Festival season, maximum number of users  will place order, view products  with same response time.
System will be able to manage all transactions with isolation.

### Modularity:
System will designed and developed using reusable, independent or dependent business senarios in the form of modules.
These modules will be loosely coupled and highly cohesive.
System will contain CRM , Inventory , shopping cart, order processing, payment processing, Delivery module, membership and Roles managment  modules.
	
### Scalability:
System will be able  to  provide  consistent user exeprience to stake holder as well as vistors irrespective of load.

### Safety:	
online shopping portal will be secure from malicious attack, fishing.
online shoppping portal functionalilites are protected from outside with prper firewall configuration.
online shopping portal will be always kept updated with latest anit virus software.
Bussiness data will be backed up periodically to ensure safty of data using increamental back up strategy.
Role based security will be applied for Application data and operations accessibility.
