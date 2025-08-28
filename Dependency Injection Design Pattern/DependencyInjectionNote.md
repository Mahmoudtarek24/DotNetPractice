                                                   Tight Coupling 
when classes are highly dependent on each other , making them hard to modify and test 
When classes have hard-coded values that need to change in different environments during the application’s lifecycle,
this is also considered tight coupling. This is because to change the value,
you depend on the class itself. At the same time, such values can be managed without modifying the classes directly.

High dependency occurs when:

1- Classes directly create an instance of another class
      
Disadvantage
 For example, if I want to change from Email to SMS, I will also need to modify the OrderService class.

Also, here I am usually tied to using the Email type and cannot change it.
But if I use an interface, I can switch to any class that implements it.


2- Inheritance Coupling

A derived class strongly depends on its parent class, and any change in the parent class can affect it.
For example, with inheritance, if the Save method in BaseRepository changes its structure, 
it will affect the derived classes and need to modify changes.


3- Dependency on Static Methods

When code calls a static method, it creates tight coupling to the called code. How?
1- When I call a static method in my class, and later want to change this static code, I will also need to change 
the class that calls it.

2- A static method cannot implement any interface and therefore cannot be used in abstraction.


4- Hard-CODED VALUES 

When we put values like API keys, tokens, connection strings, or encryption keys directly inside our classes, 
it causes problems.

These values should not be placed directly in the code because they are not fixed and can change between 
development and deployment.
For example, a connection string, API key, or token is sensitive data and must be stored in appsettings.json or user secrets.

One way to solve this problem is to depend on appsettings.json and read the values from it.


                                                
                                                    Loose Coupling

loose coupling mean two object are independent of each other, that mean if change on object will not affect on another object 
allow to manage future changes easily and modify

                                                    Dependency Injection
                                                     
first on our example when work without Dependency Injection on OrderService when he need to used EmailServices he create object
from it  => then he dependent on another class

with Dependency Injection OrderService he think like this way "i need to send some kind of notification , so i will depend on
something that can modify=="SendNotification" "

The Dependency Injection is a process in which we are injecting the dependent object of a class into a class 
that depends on that object.


Benefits of Dependency Injection (DI)
1- Removes dependencies between objects by passing the dependent object into the class that depends on it.
2- Allows passing different behaviors by sending different objects, without changing the code that uses them.
3- Achieves Single Responsibility by making the class that uses the dependent object only call its methods.
   For example, in OrderService, we call the method from EmailService to notify the user that the order has been shipped.
4- Achieves loose coupling (maintainability): any change in the dependent class will not affect my code, 
   since I usually depend on abstraction.