INSERT INTO Roots(name) VALUES ('Level 1')
INSERT INTO Roots(name) VALUES ('Level 2')
INSERT INTO Roots(name) VALUES ('Level 3')
INSERT INTO Roots(name) VALUES ('Level 4')

INSERT INTO Factory(name, parent_ID) VALUES ('Level 1-1', 1)
INSERT INTO Factory(name, parent_ID) VALUES ('Level 1-2', 1)

select * from Roots 
select * from Factory 