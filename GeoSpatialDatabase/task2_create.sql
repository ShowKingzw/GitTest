Create Database SPJ;

Create Table S
(
	SNO char(2) Constraint pk_S Primary Key,
	SNAME Varchar(6),
	STATUS Smallint,
	CITY Char(4)
);

Create Table P
(
	PNO Char(2) Constraint pk_P Primary Key,
	PNAME Varchar(6),
	COLOR Char(2),
	WEIGHT Smallint
);


Create Table J
(
	JNO Char(2) Constraint pk_J Primary Key,
	JNAME Varchar(8),
	CITY Char(4)
);

Create Table SPJ
(
	SNO Char(2) Constraint fk_SPJ_SNO Foreign Key References S(SNO),
	PNO Char(2) Constraint fk_SPJ_PNO Foreign Key References P(PNO),
	JNO Char(2) Constraint fk_SPJ_JNO Foreign Key References J(JNO),
	QTY Smallint,
	Constraint pk_SPJ Primary Key (SNO,PNO,JNO)
);