CREATE TABLE IF NOT EXISTS Products (
	Id VARCHAR(50) NOT NULL,
	Name VARCHAR(100) NOT NULL,
	Price INTEGER NOT NULL,
	PRIMARY KEY (Id)
);

INSERT INTO Products (Id, Name, Price) VALUES ('8ec64265-da91-4360-999e-e317dc326271', 'Martelo',  50);
INSERT INTO Products (Id, Name, Price) VALUES ('ddd952ce-6a63-4f08-8587-ac6965e6cebd', 'Marreta',  150);
