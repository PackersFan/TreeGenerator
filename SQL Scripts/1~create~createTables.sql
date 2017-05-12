/* 
Author: Carson Smith 
Description: This creates the roots table which contains the top level parent nodes. 
			 It also creates the factory table which contains "children". 


*/ 

CREATE TABLE Factory ( 

ID					int			PRIMARY KEY IDENTITY(1,1),
depth				int,			
parent_ID			int			FOREIGN KEY REFERENCES Factory(ID),
name				varchar(255),
low_bound			int			DEFAULT 0 ,
up_bound			int			DEFAULT 15,
active				int			DEFAULT 1
); 
