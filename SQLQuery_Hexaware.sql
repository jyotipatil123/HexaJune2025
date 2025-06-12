
DBA : role : assign the rights
unauthorized access will be denied 

.sql 
Types of SQL : 
Oracle , PL SQl,My sql, DB2, MongoDb, Postge SQl..........

Database : 
collection of tables 
collection of views, functions, sps , rules, assemblies...

Table : table is collection of records
row- record , column -attribute 

Commands : 
1. creating the DB

create database JuneDB

2. drop the DB

drop database JuneDB

3. Rename the DB
ALTER DATABASE [current_database_name] MODIFY NAME = [new_database_name];

alter database JuneDB modify name="JuneDB123"
------------------------------------------------------------------------------
sytem Databases:
1. master :  stores system level information, including server configuration
2. msdb  : used by SQl server agent for scheduling jobs and alerts
3. model : serves as a template for creating new databases
4. tempdb : stores temporary objects and is recreated every time sql server starts
-------------------------------------------------------------------------------
Setting the available database : 
use JuneDB123

Advantages : 
1. High performance 
2. Security features 
3. scalability
4. Integration with Microsoft tools  
5.  backup and recovery  (disaster recovery)
6. Advanced data analytics 

NoSQL / MongoDB advantages : 
1. flexible schema 
2. high scalability : distribution of data across multiple servers
3. fast peformance
4. easy integration
5. high availablity 

Disadvantages of NoSQL :
1. High memory usage
2. indexing limitations
3. Limited joins
4. not ideal for relational data 
5. backup complexity 

Identifying System databases in Sql server 


Keys : 
1. Primary key   PK  key symbol
   one column or more than one column combination 
   uniquely identified within the row 
Table : 
employee
PK :slno+firstname
slno    firstname   lastname   city       ..............
10      puneet      verma      Bangalore
11      anita       patil      AP
12      anil        sharma     Delhi
10      sakshi      verma      Bangalore
14      puneet      prakash    Chennai

2. Foreign key   FK
A FOREIGN KEY is a field (or collection of fields) in one table, that refers to the 
PRIMARY KEY in another table. The table with the foreign key is called the child table,
and the table with the primary key is called the referenced or parent table.

company  
PK                  xPK
id     name        slno  FK
101    Hexaware    11
102    IBM         12
103    Wipro       13

3. canddiate keys 

within a table if you choose number of PK combinations
out of all the PK combinations , 1 combination can be chosen as PK 
rest of the keys combinations are candidate keys 
Eg : slno+firstname,  slno+lastname, firstname+lastname...............

4. alternate keys 
the left out combinations of PK are alternate keys 


Normalization : 
1NF  2NF   3NF  4NF  5NF
                BCNF

anomolies

Types of Dependencies
Partial Dependency
Full Dependency
Transitive Dependency

Tables : 
1. system defined tables
2. user defined tables 

Data types : 
int, varchar, nvarchar , xml, money , geography, date, datetime, time, datetimeoffset....

select * from student
select rollno from student
select rollno,name from student

Operators : 
1. arithemetic operators + - * / %
select 20+3, 20-3, 20/3, 20*3, 20%3 
/  quotient
%  modulus /remainder 

alias
select 20+3 'Addition Result', 20-3 , 20/3, 20*3, 20%3 
select 20+3 as 'Addition Result', 20-3 'Subtraction Result', 20/3, 20*3, 20%3 

2. relational operators  < > <= >= <>  !=
select * from student where rollno <14
select * from student where rollno >12

select * from student where rollno <=14
select * from student where rollno >=14

select * from student where rollno !=14
select * from student where rollno <> 14


3. logical operators  and , or , not 
select * from student where rollno>12 and name='anita'
select * from student where rollno>12 or name='anita'
select * from student where rollno>12 and name!='anita'


4. increment/decrement operators xxxx
5. comparison operators ==
select * from student where rollno==14     xxxxxxxxxxx

6. shortcut operators += , -=, *=, /=, %=
declare @a as int
set @a=10
set @a+=5
print @a
---------------------------------------------------------------

DECLARE @TestVariable AS VARCHAR(100)
SET @TestVariable = 'One Planet One Life'
PRINT @TestVariable

========================================================================

select * from demo1
-------------------------------------------------------------------------
Renaming the table : 

EXEC sp_rename 'demo1', 'demo2';
-------------------------------------------------------------------------
Dropping the table : 

drop table demo2
---------------------------------------------------------------------------
student 
studid   name   sub1_marks   sub2_marks   sub3_marks  city

Questions : 
1. display all records 
2. display all records where name='abhishek'
3. display all records where studid >15
4. display all records where name is not ='abhishek'

5. add new column grade varchar(1) in student table 
6. change the data type of name to varchar(100) in student table
--comment lines

7. remove a column
alter table student drop column name

8. create a new table with primary key 
9. apply PK to studid in student table
tomorrow 




8. 