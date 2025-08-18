                                                            Encapsulation

the benefits of using encapsulation
1- data hiding
2- prevent to access object member only through method  or getter, setter 
3- validate data before save it
4- used on computed property 
5- cash by value of filed , dint execute it if have value 
6 -used on change track and dint execute action unnecessary

Encapsulation improves maintainability by centralized our logic only one place ,any change will be only on this place

 Disadvantages of encapsulation 1- not direct memory access
 

What happens if you don’t use encapsulation?

 1- You cannot validate the values assigned to fields.
 2- Fields can be accessed from anywhere.
 3- You won’t have a centralized property to apply your logic when setting values.

 

==> used Interface with Has a relationship

Using an interface gives more flexibility because it provides our contract methods, and many derived classes can implement 
it in accordance with their requirements.

==> Composition characteristics: when the container class dies, the contained object will also die.
The contained object is created inside the container class.

==> Aggregation characteristics: if the container object dies, the contained object will not die.
The contained object is not created inside the container class; it is passed to the class constructor or method.


                                                   Inheritance

C# doesn’t support multiple inheritance because of the problem of ambiguity.
To explain this, suppose we have two classes, and both have the same method "Print()".
If we make our class inherit from these two classes,
an ambiguity problem will occur: the compiler will not know which method from which class to call. 
That’s the reason we don’t have multiple inheritance with classes in C#.


We can solve this problem by using interfaces.
To explain this, if we have two interfaces and both have the same method name,
and we make a class inherit from these two interfaces, t
here will be no ambiguity problem because an interface only checks if its methods are implemented 
and interface din't knows nothing about the other interface.


what happened if class inherit from class and interface have same method name 

    public interface IPrinter
    {
        void Print();
    }
    public class BaseClass
    {
        public void Print() => Console.WriteLine("BaseClass Print");
    }
    public class DerivedClass : BaseClass, IPrinter
    {
      // no need to implement Print() because BaseClass implement it

      // can used implicit call for interface 
       void IPrinter.Print() { }
    }

 Types of inheritance:

Single-level inheritance – one parent class and one child class.

Multi-level inheritance – inheritance through multiple levels (grandparent ? parent ? child).

Hierarchical inheritance – one parent class with multiple child classes ( Animal ? Dog, Cat).

Multiple inheritance – implemented in C# using interfaces.