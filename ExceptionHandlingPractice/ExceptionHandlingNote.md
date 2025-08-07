we have to type of error  1- compilation error   2- runtime error 

1- compliation error occure when forget ";" , assign string to int variable , create object from interface or abstract class 
all of this Cause compliation error , denefit of compliation error that is Visible when we write code  

2- runtime error  error occure at the time of execution program , As a result of  logical error like divide on zero , try to access index not on  array ..... , this runtime error lead to abnormal termination to program and dint not execute any next line of code 

"compilation error" only check the synyex not logic error

Exception is a class that been throw by clr "create object from exception class" to abnormal termination of program when error occure on program execution , render to user not friendly message 

=> we used try catch block to catch error on catch block then try to solve this error , also to render friendly message to user  

=> we used try ,catch block to stop   abnormal termination to program

=>some characteristics for catch 
1- we can used more than catch every one handle specific error , and finally of set of catch we put generic catch to handle all error , if specific din't handle error  

2- catch take only one exception 

=> finally block 
 first we can used finally like this 1(try {}catch{} finally{}) / (try{}finally{}) 
 we used to make sure that  that code inside it will going to execute whatever try or catch execute  

 ===> type of exception  1- system exception 2- application exception
 1 - system exception will implicit execute  "id code have erro , catch will handle it"
 2- application / custom need explicit raised  "on code need to write threw new MyCustomException  "

                                                  Exception Handle Abuse

we should be carefully when we used try- catch block , we must dint used it on the wrong place , and used it Unnecessarily                                                   

the Exception is expensive from (performance , memory "StackTrace")

we used try-catch block When we can't expect that this code will execute error like database connection , read from file


 
