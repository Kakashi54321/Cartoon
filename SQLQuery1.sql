CREATE DATABASE sample

USE sample

CREATE TABLE sampletb(
	id_sampletb	int,
	name_sampletb	VARCHAR(15),
	CONSTRAINT pk_id_sampletb	PRIMARY KEY (id_sampletb)
)

ALTER TABLE sampletb ADD age int

Drop TABLE sampletb;

-------------Write the SQL code that will create the table structures for Emp and Job------------------------
CREATE TABLE jobtb(
	job_id int,
	job_title VARCHAR(20) not null,
	min_salary int,
	max_salary int,
	CONSTRAINT pk_job_id PRIMARY KEY (job_id)
);

CREATE TABLE emptb(
	emp_num int,
	emp_lname VARCHAR(20),
	emp_fname VARCHAR(20),
	emp_initial char,
	emp_hiredate date,
	job_code int,
	CONSTRAINT pk_emp_num PRIMARY KEY (emp_num),
	CONSTRAINT fk_job_code Foreign Key(job_code) references jobtb(job_id)
);
---------------Write the SQL statement to add a column STARS(VARCHAR(5) to the table JOB that has a default value of 1 *.
ALTER TABLE jobtb ADD stars VARCHAR(5) DEFAULT '1';
--------------Write the SQL statement to delete a column “MAX_SALARY” in job Table-------------------
ALTER TABLE jobtb DROP COLUMN max_salary;


ALTER TABLE jobtb ADD max_salary int;

INSERT into jobtb(job_id, job_title, min_salary,max_salary) VALUES(1, 'manager', 100, 1000);

ALTER TABLE emptb
ADD CONSTRAINT CK_emp_num CHECK (
   emp_num BETWEEN 0 AND 100
);

ALTER TABLE emptb
ADD CONSTRAINT ck_emp_initial  CHECK(
	emp_initial BETWEEN 'A' AND 'Z'
);

SELECT * from jobtb;

INSERT into emptb(emp_num,
	emp_lname ,
	emp_fname ,
	emp_initial ,
	emp_hiredate,
	job_code) VALUES (1, 'nilesh', 'prasad','np','2000-02-10',1);

ALTER TABLE jobtb MODIFY  job_id int NOT NULL AUTO_INCREMENT;