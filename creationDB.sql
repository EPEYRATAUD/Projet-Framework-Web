create table race (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    EventDate DATE NOT NULL,
    StartHour TIME NOT NULL,
    Latitude Decimal(8,6) NOT NULL,
    Longitude Decimal(9,6) NOT NULL,
    MaxEntryAmount INT DEFAULT '15',
    Image VARCHAR(500),
    DriversArrayID INT NOT NULL,
    MinAge INT DEFAULT '15',
    ResultArrayID INT NOT NULL,
    RaceCategoryArrayID INT NOT NULL
);

create table driver (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    FirstName VARCHAR(30) NOT NULL,
    LastName VARCHAR(30) NOT NULL,
    Birthdate DATE NOT NULL,
    Email VARCHAR(500) NOT NULL,
    Password VARCHAR(500) NOT NULL,
    OwnedVehiculesArrayID INT NOT NULL,
    RacesArrayID INT NOT NULL
);

create table car (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    CategoryArrayID INT NOT NULL,
    ConstructionYear INT NOT NULL,
    Brand VARCHAR(500) NOT NULL,
    Model VARCHAR(500) NOT NULL,
    PowerLevel INT NOT NULL,
    OwnersArrayID INT NOT NULL,
    Image VARCHAR(500) NOT NULL
);

create table CarCategory (
    CarID INT NOT NULL,
    Name VARCHAR(500) NOT NULL,
    Description VARCHAR(500) NOT NULL,
    Image  VARCHAR(500) NOT NULL,
    Color VARCHAR(500) NOT NULL
);

create table driverArray (
    RaceID INT NOT NULL,
    DriverID INT NOT NULL
);

create table resultArray (
    RaceID INT NOT NULL,
    DriverID INT NOT NULL,
    Rankk INT NOT NULL
);

create table raceCategoryArray (
    RaceCategoryID INT NOT NULL,
    RaceID INT NOT NULL,
    Name VARCHAR(500) NOT NULL
);

create table ownedVehiculesArray (
    DriverID INT NOT NULL,
    CarID INT NOT NULL
);

create table racesArray (
    DriverID INT NOT NULL,
    CarID INT NOT NULL
);

create table carCategoryArray (
    CarID INT NOT NULL,
    CategoryID INT NOT NULL
);

create table carOwnersArray (
    CarID INT NOT NULL,
    CategoryID INT NOT NULL
);
