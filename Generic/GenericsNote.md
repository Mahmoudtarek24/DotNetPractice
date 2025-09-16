                                                     Generics

Why do we need Generics in C#?
allow to define classes and method for general-purpose , generic allow to define classes and method with placeholder and this 
placeholder will replace with specific type at compilation time 


Advantages of Generics in C#
1- Increases the Reusability of code you can used same method with different data type
2- type safe when define generic compiler enforce the type during compile time ,avoid run time error
3- avoid boxing and unboxing lead to better performance 


operation valid inside generic method
1- assign value to object datatype
2- pass value to method accept object type parameter 
3- used all method of object class
4- take default value "T= default"

operation not valid 
1- set value to null or zero its treat as object dint know what her default value 
2- can not create object from it 


























