DROP TABLE IF EXISTS SystemLog, Player, Movie, Event, Promotion, Cinema, Employee, Theater, PlayerMovie;

CREATE TABLE SystemLog
(
Id char(36) NOT NULL,
DateCreated DateTime NOT NULL,
Message longtext NOT NULL,
PRIMARY KEY(Id)
);

CREATE TABLE Player
(
Id char(36) NOT NULL,
PlayerName varchar(255) NOT NULL UNIQUE,
HighScore float DEFAULT 0.00,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY(Id)
);

CREATE TABLE Movie
(
Id char(36) NOT NULL,
Title varchar(255) NOT NULL,
Synopsis varchar(255) NOT NULL,
ExpectedPopularity float NOT NULL,
ActualPopularity float NOT NULL,
OptimalSeason int NOT NULL,
WorstSeason int NOT NULL,
CostLicense float NOT NULL,
LicenseLength int NOT NULL,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY (Id)
);

CREATE TABLE Event
(
Id char(36) NOT NULL,
Description varchar(255) NOT NULL,
Option1 varchar(255) NOT NULL,
Option2 varchar(255) NOT NULL,
Option3 varchar(255) NOT NULL,
Option4 varchar(255) NOT NULL,
Result1 varchar(255) NOT NULL,
Result2 varchar(255) NOT NULL,
Result3 varchar(255) NOT NULL,
Result4 varchar(255) NOT NULL,
GainLoss1 float NOT NULL,
GainLoss2 float NOT NULL,
GainLoss3 float NOT NULL,
GainLoss4 float NOT NULL,
Chance float NOT NULL,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY (Id)
);

CREATE TABLE Promotion
(
Id char(36) NOT NULL,
Details varchar(255) NOT NULL,
Cost float NOT NULL,
Effectiveness float NOT NULL,
ChanceFail float NOT NULL,
MaxGain float NOT NULL,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY (Id)
);

CREATE TABLE Cinema
(
Id char(36) NOT NULL,
Name varchar(255) NOT NULL,
PromoId char(36),
NumTheaters int DEFAULT 1,
Bank float DEFAULT 0.00,
NumLicenses int DEFAULT 0,
NumSnacks int DEFAULT 0,
TicketPrice float DEFAULT 10.00,
TotalWeekRevenueTicket float DEFAULT 0.00,
TotalWeekRevenueFood float DEFAULT 0.00,
TotalWeekExpenses float DEFAULT 0.00,
TotalProfitLoss float DEFAULT 0.00,
NumEmployees int DEFAULT 0,
PlayerId char(36),
Week int DEFAULT 1,
Year int DEFAULT 1,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY(Id),
FOREIGN KEY(PlayerId) REFERENCES Player(Id),
FOREIGN KEY(PromoId) REFERENCES Promotion(Id)
);

CREATE TABLE Employee
(
Id char(36) NOT NULL,
PlayerId char(36),
CinemaId char(36),
FirstName varchar(255) NOT NULL,
LastName varchar(255) NOT NULL,
Age int NOT NULL,
Bio varchar(255) NOT NULL,
Salary float NOT NULL,
Attitude float NOT NULL,
Experience float NOT NULL,
PositiveTrait varchar(255) NOT NULL,
PositiveTraitScore float NOT NULL,
NegativeTrait varchar(255) NOT NULL,
NegativeTraitScore float NOT NULL,
Traitor tinyint(1) DEFAULT NULL,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY (Id),
FOREIGN KEY (CinemaId) REFERENCES Cinema(Id),
FOREIGN KEY (PlayerId) REFERENCES Player(Id)
);

CREATE TABLE Theater
(
Id char(36) NOT NULL,
CinemaId char(36),
MovieId char(36),
PlayerId char(36),
SoundLevel float DEFAULT 0.00,
ScreenLevel float DEFAULT 0.00,
ProjectorLevel float DEFAULT 0.00,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY(Id),
FOREIGN KEY(CinemaId) REFERENCES Cinema(Id),
FOREIGN KEY(MovieId) REFERENCES Movie(Id),
FOREIGN KEY(PlayerId) REFERENCES Player(Id)
);

CREATE TABLE PlayerMovie
(
Id char(36) NOT NULL,
MovieId char(36),
PlayerId char(36),
Owned tinyint(1) DEFAULT NULL,
LicenseRemaining int NOT NULL,
Available tinyint(1) DEFAULT NULL,
DateCreated timestamp NOT NULL,
DateModified timestamp NOT NULL,
PRIMARY KEY (Id),
FOREIGN KEY (MovieId) REFERENCES Movie(Id),
FOREIGN KEY (PlayerId) REFERENCES Player(Id)
);