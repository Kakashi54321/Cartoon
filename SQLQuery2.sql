use SampleDB;		--accessing the databases


--without using JOIN keyword
SELECT team_name_team, developer_name_developer, work_place_developer, emp_salary 
FROM team, developer, salary 
WHERE team_id_team=team_id_developer AND developer_id_developer=emp_developer_id AND emp_salary BETWEEN 30000 AND 45000;



--using JOIN keyword
SELECT team_name_team, developer_name_developer, work_place_developer, emp_salary 
FROM team
JOIN developer ON(team_id_team = team_id_developer) JOIN salary ON (developer_id_developer=emp_developer_id)
WHERE emp_salary BETWEEN 30000 AND 45000;

--DOT Net		Sikandra		Bangalore		30000
--Windows		Aster			Bangalore		45000
--UI			Munaswamy		Bangalore		31000
--Windows		Harish			Bangalore		39000
--Android		Abhin			Bangalore		40000





CREATE TABLE team				--creating the table team
(
	team_id_team INT NOT NULL,
	team_name_team VARCHAR(256) NOT NULL,
	team_lead_team VARCHAR(256) NOT NULL, 
	last_updated_team DATETIME NOT NULL,
	CONSTRAINT PK_team_id_team PRIMARY KEY (team_id_team)
);




CREATE TABLE developer			--creating the table developer
(
	developer_id_developer VARCHAR(38) NOT NULL,
	developer_name_developer VARCHAR(256) NOT NULL,
	team_id_developer INT DEFAULT NULL,
	joining_date_developer DATE NOT NULL, 
	work_place_developer VARCHAR(256) NOT NULL,
	CONSTRAINT PK_developer_id_developer PRIMARY KEY (developer_id_developer),
	CONSTRAINT FK_team_id_developer FOREIGN KEY (team_id_developer) REFERENCES team(team_id_team)
);




CREATE TABLE salary				--creating the table salary
(
	emp_developer_id VARCHAR(38) NOT NULL,
	emp_salary INT NOT NULL,
	CONSTRAINT PK_emp_developer_id PRIMARY KEY (emp_developer_id),
	CONSTRAINT FK_emp_developer_id FOREIGN KEY (emp_developer_id) REFERENCES developer(developer_id_developer)

);




INSERT INTO team				--inserting the values into table team
	(team_id_team, team_name_team, team_lead_team, last_updated_team)
VALUES
	('1', 'DOT Net', 'Saurabh', '2018-06-21 19:24:30.730'),
	('2', 'UI', 'Ammeen', '2018-03-09 19:24:30.730'),
	('3', 'Architect', 'Pranay', '2016-09-17 19:24:30.730'),
	('5', 'Android', 'Abhin', '2018-02-23 19:24:30.730'),
	('8', 'Windows', 'Aster', '2017-06-29 19:24:30.730'),
	('9', 'iOS', 'Balamuralikrishna', '2017-05-28 19:24:30.730'),
	('11', 'Custom', 'Rahul', '2018-05-28 19:24:30.730');




INSERT INTO developer				--inserting the values into table developer
	(developer_id_developer, developer_name_developer, team_id_developer, joining_date_developer, work_place_developer)
VALUES 
	(NEWID(), 'Pranay', '3', '2009-10-11 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Saurabh', '9', '2011-11-23 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Aster', '8', '2011-04-17 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Ganesh Kiran', '1', '2015-07-14 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Ammeen', '2', '2015-09-29 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Harish', '8', '2014-12-03 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Shashipriya', '5', '2014-12-03 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Munaswamy', '2', '2015-12-09 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Balamuralikrishna', '9', '2016-05-09 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Abhshek Kumar Gupta', '1', '2016-08-01 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Sandeep S', '1', '2017-07-22 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Abhin', '5', '2017-07-12 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Sikandra', '1', '2017-03-20 19:24:30.730', 'Bangalore'),
	(NEWID(), 'Hetvi', '1', '2018-04-13 19:24:30.730', 'Rajkot'),
	(NEWID(), 'Divya', '1', '2018-04-27 19:24:30.730', 'Rajkot'),
	(NEWID(), 'Ankita', '5', '2018-05-19 19:24:30.730', 'Rajkot'),
	(NEWID(), 'Mahesh', NULL, '2018-06-25 19:24:30.730', 'Chennai');





INSERT INTO salary				--inserting the values into table salary
	(emp_developer_id, emp_salary)
VALUES
	('0261D704-2ED9-40AF-A997-D48A8BF22CFA', '30000'),
	('2800E53E-B130-40F8-B124-50AE84FB73AB', '10000'),
	('AD6E9AC7-1CB9-4098-8C96-7DC4A17DDB29', '31000'),
	('8831FCF2-E008-467B-84A8-F629B1BF0F04', '60000'),
	('EB06C5DF-0F98-4F1D-8CEE-000E18AF0CBA', '40000'),
	('A03CF2CA-AC47-4A3C-9046-EBC8C3EECB6F', '45000'),
	('82036E9B-E036-4B50-967B-BF6F5E232EB4', '15000'),
	('DA47F08B-4000-4A8E-BDA0-7F278E46C79E', '39000'),
	('1DD1F25F-7DCE-4E30-BC92-C0DFF4166D0E', '65000');
	

