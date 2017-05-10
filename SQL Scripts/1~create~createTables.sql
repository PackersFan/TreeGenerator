/* 
Author: Carson Smith 
Description: This creates the roots table which contains the top level parent nodes. 
			 It also creates the factory table which contains "children". 


*/ 

CREATE TABLE Roots ( 

ID					int			PRIMARY KEY,
name				varchar(255), 
children_count		int,
active				int

);

CREATE TABLE Factory ( 

ID					int			PRIMARY KEY,
parent				int			FOREIGN KEY REFERENCES Factory(ID),
name				varchar(255),
children_count		int,
low_bound			int			DEFAULT 0 ,
up_bound			int			DEFAULT 15

); 
