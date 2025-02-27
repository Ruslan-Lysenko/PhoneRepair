-- Таблица для сотрудников
CREATE TABLE EmployeesINST (
    EmployeeId BIGINT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName NVARCHAR(100) NOT NULL
);