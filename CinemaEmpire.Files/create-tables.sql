DROP TABLE IF EXISTS SystemLog, Player, Movie, Event, Promotion, Cinema, Employee, Theater, PlayerMovie;

CREATE TABLE SystemLog
(
Id int NOT NULL,
DateCreated DateTime NOT NULL,
Message longtext NOT NULL,
PRIMARY KEY(Id)
);

CREATE TABLE Player
(
Id int NOT NULL AUTO_INCREMENT,
PlayerName varchar(255) NOT NULL UNIQUE,
HighScore float DEFAULT 0.00,
CreatedAt timestamp NOT NULL,
PRIMARY KEY(Id)
);

CREATE TABLE Movie
(
Id int NOT NULL AUTO_INCREMENT,
Title varchar(255) NOT NULL,
Synopsis varchar(255) NOT NULL,
ExpectedPopularity float NOT NULL,
ActualPopularity float NOT NULL,
OptimalSeason int NOT NULL,
WorstSeason int NOT NULL,
CostLicense float NOT NULL,
LicenseLength int NOT NULL,
PRIMARY KEY (Id)
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Snow Fortress",
"With global warming fast on the rise, Jack Irons (Keeanu Forrester) must lead the remnants of human civilization to the one place cold enough to survive--Snow Fortress.",
0.6,
0.6,
1,
3,
200.00,
52
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Love and Laughter",
"In this romantic comedy, Jerimiah Weiss (Michael Stillborn) uses laughter to woo the one that almost got away. But, is his sense of humor really enough?",
0.8,
0.8,
1,
0,
400.00,
16
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Total Vengeance - 2 Angry",
"The law failed him. The universe failed him. It's time for John Steel (Ice-Cicle) to point the deadly finger of blame at everyone except himself for total Vengeance.",
0.8,
1.0,
2,
3,
500.00,
12
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Boiling Point",
"In this documentary by Ben Childes, the nature of global warming is revealed. The truth will have you sweating the future.",
0.4,
0.4,
2,
0,
200.00,
24
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Death on Wheels",
"This critically crucified indie flick gives you everything you need to be on the edge of your seat: fast cars, big explosions, and babes.",
0.2,
0.2,
0,
2,
100.00,
28
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Sitting In",
"She said, 'No' and the entire world heard. This historical drama follows the life of Rosa Parks, the unsung American hero.",
0.6,
0.6,
0,
1,
300.00,
20
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Total Vengeance - Dying Hard",
"Just when he thinks there's no one left to kill, John Steel (Ice-Cicle) meets Michael Sharp (Pocket-Change). The angriest man wins.",
0.8,
0.6,
2,
3,
400.00,
16
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Escape From Al-CAT-traz",
"That pesky feline, Meowzer, can't stop getting into trouble. They've locked him up, and thrown away the key in this animated film. Will it be enough to hold him?",
0.8,
1.0,
3,
2,
400.00,
16
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Desperate Enough",
"He lost his job, his house, and his wife. If that wasn't bad enough, the Dr. says he's dying. High School physics teacher Milo vows to do something big before the end.",
0.4,
0.4,
0,
1,
200.00,
24
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"The Chronicles of Black",
"While being chased by the insane leader of an alien cult, Intergalactic space pirate Ian Black must steal the universe's most advanced computer.",
1.0,
1.0,
1,
0,
500.00,
12
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Badangus",
"The only Asian cowboy the Wild West ever bothered to remember, Badangus takes on a greedy gold miner and his thugs before they can harm the locals.",
0.6,
0.6,
3,
2,
300.00,
20
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Red Rising",
"Far into the future, Red China's hungry population can no longer be sustained within its borders. What happens will reshape the civilzed world.",
0.8,
0.8,
2,
1,
400.00,
16
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Bloodied Waters",
"Nespa is a peaceful lake community in a secluded area of Missouri. At least it was before the lake coughed up something horrific.",
0.2,
0.2,
0,
3,
100.00,
28
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Clutz & Clumsy",
"If this wacky duo weren't animated, they'd by sent to the loony bin. Clutz wrecks Clumsy's car, but it's when he tries to hide it that things get crazy.",
0.4,
0.6,
1,
2,
300.00,
20
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Baby Boomers",
"These babies are packing more than a dirty diaper. Genetically enhanced and artfully drawn, Special Agent Cry-Baby and his team of tots foil terrorism.",
1.0,
0.8,
3,
0,
500.00,
12
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Captain 'O What",
"Traveling around in his large blue, Postal box-shaped space ship/time machine, Captain O'What prEvent impossible catastrophes using fake science and a quirky female sidekick.",
0.2,
0.2,
2,
3,
100.00,
28
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Living Little",
"A story about a boy who started with very little and made the most of it. It's a true rags to riches adventure.",
0.4,
0.4,
0,
2,
200.00,
24
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Infested",
"The President and the world's most powerful people have been infected with an intelligent alien life-form. It's up to a plummer and his brother to save everyone.",
0.6,
0.6,
1,
0,
300.00,
20
);

INSERT INTO Movie
(Title, Synopsis, ExpectedPopularity, ActualPopularity, OptimalSeason, WorstSeason, CostLicense, LicenseLength)
VALUES
(
"Patterns in the Stars",
"They've been waiting billions of years for the stars to align just right. Only a lonely astrologist sees it coming. But, who will listen.",
0.6,
0.6,
3,
1,
300.00,
20
);

CREATE TABLE Event
(
Id int NOT NULL AUTO_INCREMENT,
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
PRIMARY KEY (Id)
);

CREATE TABLE Promotion
(
Id int NOT NULL AUTO_INCREMENT,
Details varchar(255) NOT NULL,
Cost float NOT NULL,
Effectiveness float NOT NULL,
ChanceFail float NOT NULL,
MaxGain float NOT NULL,
PRIMARY KEY (Id)
);

CREATE TABLE Cinema
(
Id int NOT NULL AUTO_INCREMENT,
Name varchar(255) NOT NULL,
PromoId int,
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
PlayerId int,
Week int DEFAULT 1,
Year int DEFAULT 1,
PRIMARY KEY(Id),
FOREIGN KEY(PlayerId) REFERENCES Player(Id),
FOREIGN KEY(PromoId) REFERENCES Promotion(Id)
);

CREATE TABLE Employee
(
Id int NOT NULL AUTO_INCREMENT,
PlayerId int,
CinemaId int,
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
PRIMARY KEY (Id),
FOREIGN KEY (CinemaId) REFERENCES Cinema(Id),
FOREIGN KEY (PlayerId) REFERENCES Player(Id)
);

CREATE TABLE Theater
(
Id int NOT NULL AUTO_INCREMENT,
CinemaId int,
MovieId int,
PlayerId int,
SoundLevel float DEFAULT 0.00,
ScreenLevel float DEFAULT 0.00,
ProjectorLevel float DEFAULT 0.00,
PRIMARY KEY(Id),
FOREIGN KEY(CinemaId) REFERENCES Cinema(Id),
FOREIGN KEY(MovieId) REFERENCES Movie(Id),
FOREIGN KEY(PlayerId) REFERENCES Player(Id)
);

CREATE TABLE PlayerMovie
(
Id int NOT NULL AUTO_INCREMENT,
MovieId int,
PlayerId int,
Owned tinyint(1) DEFAULT NULL,
LicenseRemaining int NOT NULL,
Available tinyint(1) DEFAULT NULL,
PRIMARY KEY (Id),
FOREIGN KEY (MovieId) REFERENCES Movie(Id),
FOREIGN KEY (PlayerId) REFERENCES Player(Id)
);