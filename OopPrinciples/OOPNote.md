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

 What happens if you don't use encapsulation?
  we not validate value assign to filed , can access filed from any ware , will not have centralized "property" to set our logic

 

==> used Interface with Has a relationship

Using an interface gives more flexibility because it provides our contract methods, and many derived classes can implement 
it in accordance with their requirements.

==> Composition characteristics: when the container class dies, the contained object will also die.
The contained object is created inside the container class.

==> Aggregation characteristics: if the container object dies, the contained object will not die.
The contained object is not created inside the container class; it is passed to the class constructor or method.


                                                   