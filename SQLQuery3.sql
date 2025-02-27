-- Таблица для сотрудников
CREATE TABLE Employees (
    EmployeeId BIGINT IDENTITY(1,1) PRIMARY KEY,
    EmployeeName NVARCHAR(100) NOT NULL
);

-- Промежуточная таблица 
CREATE TABLE OrderProcessing (
    OrderProcessingId BIGINT IDENTITY(1,1) PRIMARY KEY,
    OrderId BIGINT NOT NULL,
    EmployeeId BIGINT NOT NULL,
    IsCompleted BIT NOT NULL,
    FOREIGN KEY (OrderId) REFERENCES PhoneOrder(id),
    FOREIGN KEY (EmployeeId) REFERENCES Employees(EmployeeId)
);
