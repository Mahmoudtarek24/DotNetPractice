1- We use a copy constructor to create an object with the same values as another object "another object on head "

That’s why a copy constructor takes another object to copy from, unlike assigning an object to a variable 
of the same class type


When two references point to the same object, changing a variable through one reference will reflect in the original object
In contrast, a copy constructor creates a separate object, so changes made to the copy will not affect the original object

Example 

 Employee emp1 =new Employee();
 Employee empVariable =emp1  ;   =>her same refer to same object on head 

 Employee CopyEmployee =new Employee(emp1) ;   =>can use on a test and i have orignal object will not get any change
 

we can used copy constructor on this Scenario 

Player currentPlayer = new Player();
currentPlayer.Level = 10;
currentPlayer.Health = 100;

Player checkpoint = new Player(currentPlayer);

currentPlayer.Health -= 80; 

currentPlayer = new Player(checkpoint);

 ==> can also used to compare orginal value object to update value object 
