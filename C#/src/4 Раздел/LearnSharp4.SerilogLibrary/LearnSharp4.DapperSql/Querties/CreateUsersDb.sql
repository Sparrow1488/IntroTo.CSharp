CREATE DATABASE UsersDb

USE UsersDb
CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	Login NVARCHAR(500) UNIQUE CHECK(Login != null),
	Password NVARCHAR(500) CHECK (Password != null),
	ProfileId INT
);

CREATE TABLE Profiles
(
	Id INT PRIMARY KEY IDENTITY,
	Description NVARCHAR(120),
	ImageRef NVARCHAR(1500),
	UserId INT,
	FOREIGN KEY (UserId) REFERENCES Users(Id)
);

ALTER TABLE Users
ADD FOREIGN KEY (ProfileId) REFERENCES Profiles(Id);