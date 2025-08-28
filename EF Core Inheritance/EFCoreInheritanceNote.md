                                             Table Per Hierarchy 

will build database have different type of employee (full time, Part-Time, and Contractors) they shared common property 
but have some unique characteristics.

represent as only one table for base class and derived 

Use TPH When:
1- inherited class have similar data with unique properties
2- avoid join all column on same table
 
on update operation 
1- if update data of same  its normal 
2- update data from class to another class need first to delete it then update new data 

                                             Table Per Type

base class and derived class every one represent as table on database ,derived class when represent as table it have fk from 
base class ,on query ef core execute join to get data 

Disadvantages of Table Per Type (TPT)
1- retrieve data need to execute join between tables
                                             

                                             Table Per Concrete

only derived class mapped to table on database , base class not mapped like (tpt, tph)
all properties of base class when update database it set on derive classes ,


