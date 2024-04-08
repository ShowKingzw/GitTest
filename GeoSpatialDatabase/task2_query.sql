Select Distinct SNO
From SPJ
Where JNO = 'J1';

Select P.PNAME, SPJ.QTY
From SPJ,P
Where P.PNO = SPJ.PNO And SPJ.JNO = 'J2';

Select Distinct J.JNAME
From J 
Join SPJ on J.JNO = SPJ.JNO
Where SPJ.SNO in (
	Select SNO
	From S
	Where CITY ='上海'
);

Select SNAME, CITY
From S;
