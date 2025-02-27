--select * from PhoneOrder as PO
--join OrderProcessing as OP ON PO.id=OP.OrderId
--join Employees as E ON E.EmployeeId=OP.EmployeeId
--where EmployeeName='Ruslan'
--select EmployeeName, PhoneModel from OrderProcessing as OP
--join Employees as E ON E.EmployeeId=OP.EmployeeId
--join PhoneOrder as PO ON PO.id=OP.OrderId
--where OP.EmployeeId = '1'
--DELETE FROM PhoneOrder where id = '10008'
--DBCC CHECKIDENT ('PhoneOrder', RESEED, 3);
--DELETE FROM PhoneOrder where id = '10006'
--DELETE FROM OrderProcessing where OrderProcessingId = '2'
--SELECT IDENT_CURRENT('PhoneOrder');
--SELECT COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE
--FROM INFORMATION_SCHEMA.COLUMNS
--WHERE TABLE_NAME = 'PhoneOrder';
--TRUNCATE TABLE OrderProcessing;
--DBCC CHECKIDENT ('OrderProcessing', RESEED, 1);
--DELETE FROM  PhoneOrder
--DBCC CHECKIDENT ('PhoneOrder', RESEED, 0);
select * from PhoneOrder
select * from OrderProcessing

