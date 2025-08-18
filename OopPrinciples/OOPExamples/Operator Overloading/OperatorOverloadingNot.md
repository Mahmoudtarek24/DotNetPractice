Q1: What is operator overloading in C#?
 Allow to define operation like (+,-,*,==) on normal classes to be more readable

Q3: What are the rules for operator overloading?
 1- must be static method
 2- Some operators must be overloaded in pairs (== with !=, < with >)
 3- at lest one parameter must be of class type

Q4: Why must operator overloading methods be static?
 operator overloading resolved at compilation time 
 
Q5: What happens if you overload == but forget to override Equals()?
 will compare between it based on references value to really object value

Q6: Can you overload the assignment operator (=)? No


 
